using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathgame
{
    public partial class המשחק : Form
    {
        private Random random = new Random();
        private int correctAnswer;
        private int score = 0;
        private Timer timer;
        private int timeLeft = 90; // זמן למשחק (90 שניות)
        private Label timerLabel;
        private int missnumber;
        private string opratorname;

        private void OptionButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int selectedAnswer = int.Parse(clickedButton.Text);

            if (selectedAnswer ==missnumber)
            {
                score += 10;
                MessageBox.Show($"נכון! כל הכבוד! הרווחת 10 נקודות. הציון הנוכחי שלך: {score}");
            }
            else
            {
                MessageBox.Show("טעות. נסה שוב.");
            }

            // ניקוי המסך והצגת תרגיל חדש
            GenerateExercise();
        }

        private int[] GenerateOptions(int correct)
        {
            int[] options = new int[4];
            int correctPosition = random.Next(0, 4);
            options[correctPosition] = correct;

            for (int i = 0; i < 4; i++)
            {
                if (i != correctPosition)
                {
                    int option;
                    do
                    {
                        option = random.Next(1, 30); // תחום הערכים האופציונליים
                    } while (Array.Exists(options, x => x == option));
                    options[i] = option;
                }
            }

            return options;
        }

        private void GenerateExercise()
        {
            foreach (Control control in this.Controls.OfType<Control>().Where(c => c != timerLabel && c != חזרהלתפריט).ToArray())
            {
                this.Controls.Remove(control);
            }
            //this.Controls.Clear(); // נקה את כל הרכיבים הקודמים מהחלון
            //this.Controls.Add(timerLabel); // החזר את תווית הטיימר
            int num1 = random.Next(1, 10); // מספר ראשון אקראי בין 1 ל-9
            int num2 = random.Next(1, 10); // מספר שני אקראי בין 1 ל-9
            Boolean validExercise;
            do
            {
                
                string[] operators = { "plus", "minus", "multiply", "divide" };
                string chosenOperator = operators[random.Next(0, operators.Length)];
                

                validExercise = true; // נניח שהתרגיל תקין

                switch (chosenOperator)
                {
                    case "plus":
                        correctAnswer = num1 + num2;
                        if (correctAnswer > 20) validExercise = false;
                        break;
                    case "minus":
                        if (num1 < num2)
                        {
                            validExercise = false; // להימנע מתוצאה שלילית
                        }
                        else
                        {
                            correctAnswer = num1 - num2;
                        }
                        break;
                    case "multiply":
                        correctAnswer = num1 * num2;
                        if (correctAnswer > 20) validExercise = false;
                        break;
                    case "divide":
                        // נוודא שהמספר מתחלק בצורה מדויקת ושיש תוצאה בטווח
                        if (num1 % num2 != 0 || num1 / num2 > 20)
                        {
                            validExercise = false;
                        }
                        else
                        {
                            correctAnswer = num1 / num2;
                        }
                        break;
                }

            } while (!validExercise);

            // הגדרת תמונות למספרים ולסימנים
            PictureBox num1PictureBox = new PictureBox();
            num1PictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject($"{num1}");
            num1PictureBox.Location = new Point(50, 50);
            num1PictureBox.Size = new Size(50, 50);
            num1PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(num1PictureBox);

            PictureBox operatorPictureBox = new PictureBox();
            operatorPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject($"{chosenOperator}");
            operatorPictureBox.Location = new Point(110, 50);
            operatorPictureBox.Size = new Size(50, 50);
            operatorPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(operatorPictureBox);

            PictureBox questionPictureBox = new PictureBox();
            questionPictureBox.Image = Properties.Resources.question;
            questionPictureBox.Location = new Point(170, 50);
            questionPictureBox.Size = new Size(50, 50);
            questionPictureBox.SizeMode =PictureBoxSizeMode.StretchImage;
            this.Controls.Add(questionPictureBox);

            PictureBox equalsPictureBox = new PictureBox();
            equalsPictureBox.Image = Properties.Resources.equals;
            equalsPictureBox.Location = new Point(230, 50);
            equalsPictureBox.Size = new Size(50, 50);
            equalsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(equalsPictureBox);

            PictureBox resultPictureBox = new PictureBox();
            resultPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject($"{correctAnswer}");
            resultPictureBox.Location = new Point(290, 50);
            resultPictureBox.Size = new Size(50, 50);
            resultPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(resultPictureBox);

            missnumber = num2;
            // הצגת אפשרויות
            int[] options = GenerateOptions(num2);
            for (int i = 0; i < options.Length; i=i+2)
            {
                Button optionButton = new Button();
                optionButton.Text = options[i].ToString();
                optionButton.Location = new Point(550 + (i * 50), 400);
                optionButton.Size = new Size(80, 80);
                optionButton.Click += OptionButton_Click;
                this.Controls.Add(optionButton);
                Button optionButton2 = new Button();
                optionButton2.Text = options[i+1].ToString();
                optionButton2.Location = new Point(550 + (i * 50), 500);
                optionButton2.Size = new Size(80, 80);
                optionButton2.Click += OptionButton_Click;
                this.Controls.Add(optionButton2);
            }
// חזרהלתפריט_Click();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                timerLabel.Text = $"{timeLeft / 60:D2}:{timeLeft % 60:D2}";
            }
            else
            {
                timer.Stop();
                MessageBox.Show($"הזמן נגמר! הציון שלך הוא: {score} נקודות");
                this.Close();
            }
        }

        private void InitializeCustomComponents()
        {
            timerLabel = new Label();
            timerLabel.Text = "01:30";
            timerLabel.Location = new Point(10, this.ClientSize.Height - 50);
            timerLabel.Size = new Size(70, 30);
            timerLabel.Font = new Font("Arial", 16);
            this.Controls.Add(timerLabel);

            timer = new Timer();
            timer.Interval = 1000; // טיימר שמתעדכן כל שנייה
            timer.Tick += Timer_Tick;
            timer.Start();

            GenerateExercise();
        }
        public המשחק()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void המשחק_Load(object sender, EventArgs e)
        {
            GenerateExercise();
        }

        private void חזרהלתפריט_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

