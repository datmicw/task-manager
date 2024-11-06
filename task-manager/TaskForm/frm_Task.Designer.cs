namespace task_manager
{
    partial class frm_Task
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.txt_AddText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_Add = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonTextBox7 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lb_OwnerName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_WorkspaceName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Example = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ContextMenu = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 16;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            // 
            // txt_AddText
            // 
            this.txt_AddText.Location = new System.Drawing.Point(176, 391);
            this.txt_AddText.Name = "txt_AddText";
            this.txt_AddText.Size = new System.Drawing.Size(396, 32);
            this.txt_AddText.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_AddText.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_AddText.StateCommon.Border.Rounding = 12;
            this.txt_AddText.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddText.TabIndex = 33;
            this.txt_AddText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(597, 391);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(67, 32);
            this.btn_Add.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Add.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btn_Add.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Add.StateCommon.Border.Rounding = 12;
            this.btn_Add.TabIndex = 32;
            this.btn_Add.Values.Text = "ADD";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // kryptonTextBox7
            // 
            this.kryptonTextBox7.Location = new System.Drawing.Point(12, 12);
            this.kryptonTextBox7.Name = "kryptonTextBox7";
            this.kryptonTextBox7.Size = new System.Drawing.Size(52, 26);
            this.kryptonTextBox7.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox7.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonTextBox7.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox7.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox7.TabIndex = 42;
            this.kryptonTextBox7.Text = "Owner: ";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(295, 12);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(94, 26);
            this.kryptonTextBox1.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox1.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.TabIndex = 43;
            this.kryptonTextBox1.Text = "Workspace:";
            // 
            // lb_OwnerName
            // 
            this.lb_OwnerName.Location = new System.Drawing.Point(61, 16);
            this.lb_OwnerName.Name = "lb_OwnerName";
            this.lb_OwnerName.Size = new System.Drawing.Size(46, 20);
            this.lb_OwnerName.TabIndex = 44;
            this.lb_OwnerName.Values.Text = "Owner";
            // 
            // lb_WorkspaceName
            // 
            this.lb_WorkspaceName.Location = new System.Drawing.Point(382, 16);
            this.lb_WorkspaceName.Name = "lb_WorkspaceName";
            this.lb_WorkspaceName.Size = new System.Drawing.Size(105, 20);
            this.lb_WorkspaceName.TabIndex = 45;
            this.lb_WorkspaceName.Values.Text = "WorkSpaceName";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btn_Example);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(176, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(488, 338);
            this.flowLayoutPanel1.TabIndex = 46;
            // 
            // btn_Example
            // 
            this.btn_Example.Location = new System.Drawing.Point(3, 3);
            this.btn_Example.Name = "btn_Example";
            this.btn_Example.Size = new System.Drawing.Size(478, 32);
            this.btn_Example.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_Example.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Example.StateCommon.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.btn_Example.StateCommon.Border.Color2 = System.Drawing.Color.IndianRed;
            this.btn_Example.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Example.StateCommon.Border.Rounding = 12;
            this.btn_Example.TabIndex = 47;
            this.btn_Example.Values.Text = "ADD";
            // 
            // frm_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lb_WorkspaceName);
            this.Controls.Add(this.lb_OwnerName);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.kryptonTextBox7);
            this.Controls.Add(this.txt_AddText);
            this.Controls.Add(this.btn_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Task";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.Text = "TASK";
            this.Load += new System.EventHandler(this.frm_Task_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_AddText;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Add;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_OwnerName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_WorkspaceName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Example;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu ContextMenu;
    }
}