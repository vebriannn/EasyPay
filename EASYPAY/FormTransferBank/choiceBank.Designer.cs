namespace EASYPAY.FormTransferBank
{
    partial class choiceBank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choiceBank));
            btnBca = new Button();
            btnBni = new Button();
            tbnBri = new Button();
            btnBtn = new Button();
            btnMandiri = new Button();
            btnCimb = new Button();
            SuspendLayout();
            // 
            // btnBca
            // 
            btnBca.Location = new Point(666, 169);
            btnBca.Name = "btnBca";
            btnBca.Size = new Size(75, 23);
            btnBca.TabIndex = 2;
            btnBca.Text = "Pilih";
            btnBca.UseVisualStyleBackColor = true;
            btnBca.Click += btnBca_Click;
            // 
            // btnBni
            // 
            btnBni.Location = new Point(666, 209);
            btnBni.Name = "btnBni";
            btnBni.Size = new Size(75, 23);
            btnBni.TabIndex = 3;
            btnBni.Text = "Pilih";
            btnBni.UseVisualStyleBackColor = true;
            btnBni.Click += btnBni_Click;
            // 
            // tbnBri
            // 
            tbnBri.Location = new Point(666, 257);
            tbnBri.Name = "tbnBri";
            tbnBri.Size = new Size(75, 23);
            tbnBri.TabIndex = 4;
            tbnBri.Text = "Pilih";
            tbnBri.UseVisualStyleBackColor = true;
            tbnBri.Click += tbnBri_Click;
            // 
            // btnBtn
            // 
            btnBtn.Location = new Point(666, 302);
            btnBtn.Name = "btnBtn";
            btnBtn.Size = new Size(75, 23);
            btnBtn.TabIndex = 5;
            btnBtn.Text = "Pilih";
            btnBtn.UseVisualStyleBackColor = true;
            btnBtn.Click += btnBtn_Click;
            // 
            // btnMandiri
            // 
            btnMandiri.Location = new Point(666, 347);
            btnMandiri.Name = "btnMandiri";
            btnMandiri.Size = new Size(75, 23);
            btnMandiri.TabIndex = 6;
            btnMandiri.Text = "Pilih";
            btnMandiri.UseVisualStyleBackColor = true;
            btnMandiri.Click += btnMandiri_Click;
            // 
            // btnCimb
            // 
            btnCimb.Location = new Point(666, 392);
            btnCimb.Name = "btnCimb";
            btnCimb.Size = new Size(75, 23);
            btnCimb.TabIndex = 7;
            btnCimb.Text = "Pilih";
            btnCimb.UseVisualStyleBackColor = true;
            btnCimb.Click += btnCimb_Click;
            // 
            // choiceBank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(btnCimb);
            Controls.Add(btnMandiri);
            Controls.Add(btnBtn);
            Controls.Add(tbnBri);
            Controls.Add(btnBni);
            Controls.Add(btnBca);
            DoubleBuffered = true;
            Name = "choiceBank";
            Text = "choiceBank";
            Load += choiceBank_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBca;
        private Button btnBni;
        private Button tbnBri;
        private Button btnBtn;
        private Button btnMandiri;
        private Button btnCimb;
    }
}