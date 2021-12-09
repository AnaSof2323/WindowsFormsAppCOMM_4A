
namespace WindowsFormsAppCOMM_4B
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.port_select_label = new System.Windows.Forms.Label();
            this.comboBox_PORT_NAME = new System.Windows.Forms.ComboBox();
            this.button_OPEN_PORT = new System.Windows.Forms.Button();
            this.label_STATUS_PORT = new System.Windows.Forms.Label();
            this.label_VOLTAGE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_EXIT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label_LCD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // port_select_label
            // 
            this.port_select_label.AutoSize = true;
            this.port_select_label.Location = new System.Drawing.Point(15, 29);
            this.port_select_label.Name = "port_select_label";
            this.port_select_label.Size = new System.Drawing.Size(96, 13);
            this.port_select_label.TabIndex = 0;
            this.port_select_label.Text = "Selecciona puerto:";
            this.port_select_label.Click += new System.EventHandler(this.port_select_label_Click);
            // 
            // comboBox_PORT_NAME
            // 
            this.comboBox_PORT_NAME.FormattingEnabled = true;
            this.comboBox_PORT_NAME.Location = new System.Drawing.Point(12, 61);
            this.comboBox_PORT_NAME.Name = "comboBox_PORT_NAME";
            this.comboBox_PORT_NAME.Size = new System.Drawing.Size(200, 21);
            this.comboBox_PORT_NAME.TabIndex = 1;
            this.comboBox_PORT_NAME.SelectedIndexChanged += new System.EventHandler(this.comboBox_PORT_NAME_SelectedIndexChanged);
            // 
            // button_OPEN_PORT
            // 
            this.button_OPEN_PORT.Location = new System.Drawing.Point(303, 29);
            this.button_OPEN_PORT.Name = "button_OPEN_PORT";
            this.button_OPEN_PORT.Size = new System.Drawing.Size(133, 52);
            this.button_OPEN_PORT.TabIndex = 2;
            this.button_OPEN_PORT.Text = "Open PORT";
            this.button_OPEN_PORT.UseVisualStyleBackColor = true;
            this.button_OPEN_PORT.Click += new System.EventHandler(this.button_OPEN_PORT_Click);
            // 
            // label_STATUS_PORT
            // 
            this.label_STATUS_PORT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_STATUS_PORT.Location = new System.Drawing.Point(12, 96);
            this.label_STATUS_PORT.Name = "label_STATUS_PORT";
            this.label_STATUS_PORT.Size = new System.Drawing.Size(200, 31);
            this.label_STATUS_PORT.TabIndex = 3;
            this.label_STATUS_PORT.Text = "label1";
            this.label_STATUS_PORT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_VOLTAGE
            // 
            this.label_VOLTAGE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_VOLTAGE.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_VOLTAGE.Location = new System.Drawing.Point(12, 155);
            this.label_VOLTAGE.Name = "label_VOLTAGE";
            this.label_VOLTAGE.Size = new System.Drawing.Size(99, 55);
            this.label_VOLTAGE.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Volts";
            // 
            // button_EXIT
            // 
            this.button_EXIT.Location = new System.Drawing.Point(303, 114);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(133, 49);
            this.button_EXIT.TabIndex = 6;
            this.button_EXIT.Text = "Salida";
            this.button_EXIT.UseVisualStyleBackColor = true;
            this.button_EXIT.Click += new System.EventHandler(this.button_EXIT_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(72, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(329, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_LCD
            // 
            this.label_LCD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_LCD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LCD.Location = new System.Drawing.Point(204, 194);
            this.label_LCD.Name = "label_LCD";
            this.label_LCD.Size = new System.Drawing.Size(175, 49);
            this.label_LCD.TabIndex = 10;
            this.label_LCD.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 304);
            this.Controls.Add(this.label_LCD);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_EXIT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_VOLTAGE);
            this.Controls.Add(this.label_STATUS_PORT);
            this.Controls.Add(this.button_OPEN_PORT);
            this.Controls.Add(this.comboBox_PORT_NAME);
            this.Controls.Add(this.port_select_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label port_select_label;
        private System.Windows.Forms.ComboBox comboBox_PORT_NAME;
        private System.Windows.Forms.Button button_OPEN_PORT;
        private System.Windows.Forms.Label label_STATUS_PORT;
        private System.Windows.Forms.Label label_VOLTAGE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_EXIT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_LCD;
    }
}

