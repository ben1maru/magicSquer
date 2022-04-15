
namespace Магічний_квадрат
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tlTInfo = new System.Windows.Forms.ToolTip(this.components);
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.btnAzure = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnVoilet = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.grpGame = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnContinuos = new System.Windows.Forms.Button();
            this.lblMagicNumber = new System.Windows.Forms.Label();
            this.txtSizeSquer = new System.Windows.Forms.TextBox();
            this.dgvMagicSquer = new System.Windows.Forms.DataGridView();
            this.lblSizeSquer = new System.Windows.Forms.Label();
            this.grpColor.SuspendLayout();
            this.grpGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagicSquer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(322, 67);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(81, 23);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Виконати";
            this.tlTInfo.SetToolTip(this.btnAccept, "Після прийняття розміру потрібно обрати \r\nодну комірку  і міняйте на другу кліком" +
        " на неї.\r\nНе міняйте розмір матриці після її прийняття.\r\n\r\n ");
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(124, 421);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpColor
            // 
            this.grpColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpColor.Controls.Add(this.btnAzure);
            this.grpColor.Controls.Add(this.btnBack);
            this.grpColor.Controls.Add(this.btnGreen);
            this.grpColor.Controls.Add(this.btnYellow);
            this.grpColor.Controls.Add(this.btnRed);
            this.grpColor.Controls.Add(this.btnBlue);
            this.grpColor.Controls.Add(this.btnVoilet);
            this.grpColor.Controls.Add(this.btnOrange);
            this.grpColor.Location = new System.Drawing.Point(37, 12);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(333, 484);
            this.grpColor.TabIndex = 23;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Оберіть колір";
            this.grpColor.Visible = false;
            // 
            // btnAzure
            // 
            this.btnAzure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAzure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAzure.Location = new System.Drawing.Point(22, 278);
            this.btnAzure.Name = "btnAzure";
            this.btnAzure.Size = new System.Drawing.Size(285, 48);
            this.btnAzure.TabIndex = 17;
            this.btnAzure.Text = "Голубий";
            this.btnAzure.UseVisualStyleBackColor = true;
            this.btnAzure.Click += new System.EventHandler(this.btnAzure_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGreen.BackColor = System.Drawing.Color.Transparent;
            this.btnGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGreen.Location = new System.Drawing.Point(22, 72);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(285, 38);
            this.btnGreen.TabIndex = 13;
            this.btnGreen.Text = "Зелений";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYellow.Location = new System.Drawing.Point(22, 116);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(285, 48);
            this.btnYellow.TabIndex = 14;
            this.btnYellow.Text = "Жовтий";
            this.btnYellow.UseVisualStyleBackColor = true;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnRed
            // 
            this.btnRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRed.Location = new System.Drawing.Point(22, 170);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(285, 48);
            this.btnRed.TabIndex = 15;
            this.btnRed.Text = "Червоний";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBlue.Location = new System.Drawing.Point(22, 224);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(285, 48);
            this.btnBlue.TabIndex = 16;
            this.btnBlue.Text = "Синій";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnVoilet
            // 
            this.btnVoilet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVoilet.Location = new System.Drawing.Point(22, 332);
            this.btnVoilet.Name = "btnVoilet";
            this.btnVoilet.Size = new System.Drawing.Size(285, 48);
            this.btnVoilet.TabIndex = 18;
            this.btnVoilet.Text = "Фіолетовий";
            this.btnVoilet.UseVisualStyleBackColor = true;
            this.btnVoilet.Click += new System.EventHandler(this.btnVoilet_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrange.Location = new System.Drawing.Point(22, 22);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(285, 44);
            this.btnOrange.TabIndex = 19;
            this.btnOrange.Text = "Оранжевий";
            this.btnOrange.UseVisualStyleBackColor = true;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // grpGame
            // 
            this.grpGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGame.Controls.Add(this.btnSave);
            this.grpGame.Controls.Add(this.btnColor);
            this.grpGame.Controls.Add(this.btnContinuos);
            this.grpGame.Controls.Add(this.lblMagicNumber);
            this.grpGame.Controls.Add(this.btnAccept);
            this.grpGame.Controls.Add(this.txtSizeSquer);
            this.grpGame.Controls.Add(this.dgvMagicSquer);
            this.grpGame.Controls.Add(this.lblSizeSquer);
            this.grpGame.Location = new System.Drawing.Point(-6, 1);
            this.grpGame.Name = "grpGame";
            this.grpGame.Size = new System.Drawing.Size(422, 509);
            this.grpGame.TabIndex = 24;
            this.grpGame.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(291, 451);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnColor
            // 
            this.btnColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnColor.Location = new System.Drawing.Point(18, 451);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(88, 23);
            this.btnColor.TabIndex = 10;
            this.btnColor.Text = "Зміна кольору";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnContinuos
            // 
            this.btnContinuos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnContinuos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnContinuos.Location = new System.Drawing.Point(146, 451);
            this.btnContinuos.Name = "btnContinuos";
            this.btnContinuos.Size = new System.Drawing.Size(108, 23);
            this.btnContinuos.TabIndex = 12;
            this.btnContinuos.Text = "Продовжити гру";
            this.btnContinuos.UseVisualStyleBackColor = false;
            this.btnContinuos.Click += new System.EventHandler(this.btnContinuos_Click);
            // 
            // lblMagicNumber
            // 
            this.lblMagicNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblMagicNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMagicNumber.AutoSize = true;
            this.lblMagicNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMagicNumber.Location = new System.Drawing.Point(13, 19);
            this.lblMagicNumber.Name = "lblMagicNumber";
            this.lblMagicNumber.Size = new System.Drawing.Size(154, 25);
            this.lblMagicNumber.TabIndex = 4;
            this.lblMagicNumber.Text = "Магічне число";
            // 
            // txtSizeSquer
            // 
            this.txtSizeSquer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSizeSquer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSizeSquer.Location = new System.Drawing.Point(100, 67);
            this.txtSizeSquer.Name = "txtSizeSquer";
            this.txtSizeSquer.Size = new System.Drawing.Size(216, 22);
            this.txtSizeSquer.TabIndex = 5;
            // 
            // dgvMagicSquer
            // 
            this.dgvMagicSquer.AllowUserToAddRows = false;
            this.dgvMagicSquer.AllowUserToDeleteRows = false;
            this.dgvMagicSquer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMagicSquer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMagicSquer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMagicSquer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMagicSquer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMagicSquer.GridColor = System.Drawing.Color.Coral;
            this.dgvMagicSquer.Location = new System.Drawing.Point(23, 95);
            this.dgvMagicSquer.Name = "dgvMagicSquer";
            this.dgvMagicSquer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvMagicSquer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMagicSquer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMagicSquer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMagicSquer.Size = new System.Drawing.Size(375, 326);
            this.dgvMagicSquer.TabIndex = 0;
            this.dgvMagicSquer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMagicSquer_CellClick);
            // 
            // lblSizeSquer
            // 
            this.lblSizeSquer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSizeSquer.AutoSize = true;
            this.lblSizeSquer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSizeSquer.Location = new System.Drawing.Point(13, 63);
            this.lblSizeSquer.Name = "lblSizeSquer";
            this.lblSizeSquer.Size = new System.Drawing.Size(81, 25);
            this.lblSizeSquer.TabIndex = 1;
            this.lblSizeSquer.Text = "Розмір";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 508);
            this.Controls.Add(this.grpGame);
            this.Controls.Add(this.grpColor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магічний квадрат";
            this.ResizeEnd += new System.EventHandler(this.FrmMain_ResizeEnd);
            this.grpColor.ResumeLayout(false);
            this.grpGame.ResumeLayout(false);
            this.grpGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagicSquer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip tlTInfo;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.Button btnAzure;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnVoilet;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Label lblMagicNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnContinuos;
        private System.Windows.Forms.TextBox txtSizeSquer;
        private System.Windows.Forms.DataGridView dgvMagicSquer;
        private System.Windows.Forms.Label lblSizeSquer;
        private System.Windows.Forms.GroupBox grpGame;
    }
}