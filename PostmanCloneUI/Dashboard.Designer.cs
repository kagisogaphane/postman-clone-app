namespace PostmanCloneUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formHeader = new Label();
            apiLabel = new Label();
            callApiButton = new Button();
            apiTextbox = new TextBox();
            resultsTextbox = new TextBox();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            btnFormatJson = new Button();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            formHeader.Location = new Point(50, 51);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(162, 37);
            formHeader.TabIndex = 0;
            formHeader.Text = "API TESTER";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Location = new Point(50, 135);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(42, 21);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "URL:";
            // 
            // callApiButton
            // 
            callApiButton.Location = new Point(623, 132);
            callApiButton.Name = "callApiButton";
            callApiButton.Size = new Size(52, 34);
            callApiButton.TabIndex = 3;
            callApiButton.Text = "Test";
            callApiButton.UseVisualStyleBackColor = true;
            callApiButton.Click += callApiButton_Click;
            // 
            // apiTextbox
            // 
            apiTextbox.BorderStyle = BorderStyle.FixedSingle;
            apiTextbox.Location = new Point(92, 132);
            apiTextbox.Name = "apiTextbox";
            apiTextbox.Size = new Size(506, 29);
            apiTextbox.TabIndex = 4;
            // 
            // resultsTextbox
            // 
            resultsTextbox.BackColor = Color.White;
            resultsTextbox.BorderStyle = BorderStyle.FixedSingle;
            resultsTextbox.Location = new Point(50, 244);
            resultsTextbox.Multiline = true;
            resultsTextbox.Name = "resultsTextbox";
            resultsTextbox.ReadOnly = true;
            resultsTextbox.ScrollBars = ScrollBars.Both;
            resultsTextbox.Size = new Size(625, 271);
            resultsTextbox.TabIndex = 5;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 564);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(716, 22);
            statusStrip.TabIndex = 6;
            statusStrip.Text = "statusStrip1";
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(44, 17);
            systemStatus.Text = "Ready";
            // 
            // btnFormatJson
            // 
            btnFormatJson.Location = new Point(543, 521);
            btnFormatJson.Name = "btnFormatJson";
            btnFormatJson.Size = new Size(115, 30);
            btnFormatJson.TabIndex = 7;
            btnFormatJson.Text = "Format Json";
            btnFormatJson.UseVisualStyleBackColor = true;
            btnFormatJson.Click += btnFormatJson_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(716, 586);
            Controls.Add(btnFormatJson);
            Controls.Add(statusStrip);
            Controls.Add(resultsTextbox);
            Controls.Add(apiTextbox);
            Controls.Add(callApiButton);
            Controls.Add(apiLabel);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Dashboard";
            Text = "Postman Clone";
            Load += Dashboard_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label apiLabel;
        private Button callApiButton;
        private TextBox apiTextbox;
        private TextBox resultsTextbox;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel systemStatus;
        private Button btnFormatJson;
    }
}
