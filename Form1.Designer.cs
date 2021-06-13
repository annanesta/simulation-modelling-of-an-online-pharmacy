
namespace lab4SOSAPR
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.frequencyOfOrders = new System.Windows.Forms.Label();
            this.numberOfDays = new System.Windows.Forms.Label();
            this.dayOfTheStart = new System.Windows.Forms.Label();
            this.startUpCapital = new System.Windows.Forms.Label();
            this.selectionTheDayOfModeling = new System.Windows.Forms.ComboBox();
            this.selectionOfOrdersFrequency = new System.Windows.Forms.ComboBox();
            this.selectionOfDaysNumbers = new System.Windows.Forms.ComboBox();
            this.selectionOfTheStartUpCapital = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // frequencyOfOrders
            // 
            this.frequencyOfOrders.AutoSize = true;
            this.frequencyOfOrders.Location = new System.Drawing.Point(559, 12);
            this.frequencyOfOrders.Name = "frequencyOfOrders";
            this.frequencyOfOrders.Size = new System.Drawing.Size(120, 13);
            this.frequencyOfOrders.TabIndex = 1;
            this.frequencyOfOrders.Text = "частота заказов (мин)";
            // 
            // numberOfDays
            // 
            this.numberOfDays.AutoSize = true;
            this.numberOfDays.Location = new System.Drawing.Point(559, 38);
            this.numberOfDays.Name = "numberOfDays";
            this.numberOfDays.Size = new System.Drawing.Size(92, 13);
            this.numberOfDays.TabIndex = 1;
            this.numberOfDays.Text = "количество дней";
            // 
            // dayOfTheStart
            // 
            this.dayOfTheStart.AutoSize = true;
            this.dayOfTheStart.Location = new System.Drawing.Point(559, 64);
            this.dayOfTheStart.Name = "dayOfTheStart";
            this.dayOfTheStart.Size = new System.Drawing.Size(125, 13);
            this.dayOfTheStart.TabIndex = 1;
            this.dayOfTheStart.Text = "начало моделирования";
            // 
            // startUpCapital
            // 
            this.startUpCapital.AutoSize = true;
            this.startUpCapital.Location = new System.Drawing.Point(559, 90);
            this.startUpCapital.Name = "startUpCapital";
            this.startUpCapital.Size = new System.Drawing.Size(105, 13);
            this.startUpCapital.TabIndex = 1;
            this.startUpCapital.Text = "стартовый капитал";
            // 
            // selectionTheDayOfModeling
            // 
            this.selectionTheDayOfModeling.FormattingEnabled = true;
            this.selectionTheDayOfModeling.Location = new System.Drawing.Point(688, 64);
            this.selectionTheDayOfModeling.Name = "selectionTheDayOfModeling";
            this.selectionTheDayOfModeling.Size = new System.Drawing.Size(100, 21);
            this.selectionTheDayOfModeling.TabIndex = 2;
            this.selectionTheDayOfModeling.Text = "День недели";
            // 
            // selectionOfOrdersFrequency
            // 
            this.selectionOfOrdersFrequency.FormattingEnabled = true;
            this.selectionOfOrdersFrequency.Location = new System.Drawing.Point(688, 12);
            this.selectionOfOrdersFrequency.Name = "selectionOfOrdersFrequency";
            this.selectionOfOrdersFrequency.Size = new System.Drawing.Size(100, 21);
            this.selectionOfOrdersFrequency.TabIndex = 2;
            this.selectionOfOrdersFrequency.Text = "Один раз в ...";
            // 
            // selectionOfDaysNumbers
            // 
            this.selectionOfDaysNumbers.FormattingEnabled = true;
            this.selectionOfDaysNumbers.Location = new System.Drawing.Point(688, 39);
            this.selectionOfDaysNumbers.Name = "selectionOfDaysNumbers";
            this.selectionOfDaysNumbers.Size = new System.Drawing.Size(100, 21);
            this.selectionOfDaysNumbers.TabIndex = 2;
            this.selectionOfDaysNumbers.Text = "Период моделирования";
            // 
            // selectionOfTheStartUpCapital
            // 
            this.selectionOfTheStartUpCapital.FormattingEnabled = true;
            this.selectionOfTheStartUpCapital.Location = new System.Drawing.Point(688, 90);
            this.selectionOfTheStartUpCapital.Name = "selectionOfTheStartUpCapital";
            this.selectionOfTheStartUpCapital.Size = new System.Drawing.Size(100, 21);
            this.selectionOfTheStartUpCapital.TabIndex = 2;
            this.selectionOfTheStartUpCapital.Text = "Сумма  на счете для закупки лекарств";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectionOfOrdersFrequency);
            this.Controls.Add(this.selectionOfDaysNumbers);
            this.Controls.Add(this.selectionOfTheStartUpCapital);
            this.Controls.Add(this.selectionTheDayOfModeling);
            this.Controls.Add(this.startUpCapital);
            this.Controls.Add(this.dayOfTheStart);
            this.Controls.Add(this.numberOfDays);
            this.Controls.Add(this.frequencyOfOrders);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.ClickBtnEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frequencyOfOrders;
        private System.Windows.Forms.Label numberOfDays;
        private System.Windows.Forms.Label dayOfTheStart;
        private System.Windows.Forms.Label startUpCapital;
        private System.Windows.Forms.ComboBox selectionTheDayOfModeling;
        private System.Windows.Forms.ComboBox selectionOfOrdersFrequency;
        private System.Windows.Forms.ComboBox selectionOfDaysNumbers;
        private System.Windows.Forms.ComboBox selectionOfTheStartUpCapital;
    }
}

