namespace AdoNetDataBase
{
    partial class MainForm
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
            this.DBConnectBtn = new System.Windows.Forms.Button();
            this.ResultConnectTxt = new System.Windows.Forms.TextBox();
            this.informationLbl = new System.Windows.Forms.Label();
            this.TablesCbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DBConnectBtn
            // 
            this.DBConnectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DBConnectBtn.Location = new System.Drawing.Point(607, 69);
            this.DBConnectBtn.Name = "DBConnectBtn";
            this.DBConnectBtn.Size = new System.Drawing.Size(136, 23);
            this.DBConnectBtn.TabIndex = 0;
            this.DBConnectBtn.Text = "ConnectDataBase";
            this.DBConnectBtn.UseVisualStyleBackColor = false;
            this.DBConnectBtn.Click += new System.EventHandler(this.DBConnectBtn_Click);
            // 
            // ResultConnectTxt
            // 
            this.ResultConnectTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ResultConnectTxt.Location = new System.Drawing.Point(101, 412);
            this.ResultConnectTxt.Name = "ResultConnectTxt";
            this.ResultConnectTxt.Size = new System.Drawing.Size(642, 20);
            this.ResultConnectTxt.TabIndex = 1;
            // 
            // informationLbl
            // 
            this.informationLbl.AutoSize = true;
            this.informationLbl.Location = new System.Drawing.Point(12, 419);
            this.informationLbl.Name = "informationLbl";
            this.informationLbl.Size = new System.Drawing.Size(62, 13);
            this.informationLbl.TabIndex = 2;
            this.informationLbl.Text = "Information:";
            // 
            // TablesCbx
            // 
            this.TablesCbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TablesCbx.Enabled = false;
            this.TablesCbx.FormattingEnabled = true;
            this.TablesCbx.Location = new System.Drawing.Point(607, 138);
            this.TablesCbx.Name = "TablesCbx";
            this.TablesCbx.Size = new System.Drawing.Size(136, 21);
            this.TablesCbx.TabIndex = 3;
            this.TablesCbx.Text = "Choose table";
            this.TablesCbx.SelectedIndexChanged += new System.EventHandler(this.TablesCbx_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TablesCbx);
            this.Controls.Add(this.informationLbl);
            this.Controls.Add(this.ResultConnectTxt);
            this.Controls.Add(this.DBConnectBtn);
            this.Name = "MainForm";
            this.Text = "GardenItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DBConnectBtn;
        private System.Windows.Forms.TextBox ResultConnectTxt;
        private System.Windows.Forms.Label informationLbl;
        private System.Windows.Forms.ComboBox TablesCbx;
    }
}

