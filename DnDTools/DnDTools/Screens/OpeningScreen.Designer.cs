namespace DnDTools
{
    partial class OpeningScreen
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PlayerTools = new System.Windows.Forms.TabPage();
            this.DMTools = new System.Windows.Forms.TabPage();
            this.CharacterCreator = new System.Windows.Forms.Button();
            this.DiceRoller = new System.Windows.Forms.Button();
            this.SpellList = new System.Windows.Forms.Button();
            this.Notebook = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.PlayerTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PlayerTools);
            this.tabControl1.Controls.Add(this.DMTools);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(323, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // PlayerTools
            // 
            this.PlayerTools.Controls.Add(this.Notebook);
            this.PlayerTools.Controls.Add(this.SpellList);
            this.PlayerTools.Controls.Add(this.DiceRoller);
            this.PlayerTools.Controls.Add(this.CharacterCreator);
            this.PlayerTools.Location = new System.Drawing.Point(4, 22);
            this.PlayerTools.Name = "PlayerTools";
            this.PlayerTools.Padding = new System.Windows.Forms.Padding(3);
            this.PlayerTools.Size = new System.Drawing.Size(315, 305);
            this.PlayerTools.TabIndex = 0;
            this.PlayerTools.Text = "Player Tools";
            this.PlayerTools.UseVisualStyleBackColor = true;
            // 
            // DMTools
            // 
            this.DMTools.Location = new System.Drawing.Point(4, 22);
            this.DMTools.Name = "DMTools";
            this.DMTools.Padding = new System.Windows.Forms.Padding(3);
            this.DMTools.Size = new System.Drawing.Size(258, 209);
            this.DMTools.TabIndex = 1;
            this.DMTools.Text = "DM Tools";
            this.DMTools.UseVisualStyleBackColor = true;
            // 
            // CharacterCreator
            // 
            this.CharacterCreator.Dock = System.Windows.Forms.DockStyle.Top;
            this.CharacterCreator.Location = new System.Drawing.Point(3, 3);
            this.CharacterCreator.Name = "CharacterCreator";
            this.CharacterCreator.Size = new System.Drawing.Size(309, 23);
            this.CharacterCreator.TabIndex = 0;
            this.CharacterCreator.Text = "Character Creator";
            this.CharacterCreator.UseVisualStyleBackColor = true;
            this.CharacterCreator.Click += new System.EventHandler(this.CharacterCreator_Click);
            // 
            // DiceRoller
            // 
            this.DiceRoller.AutoSize = true;
            this.DiceRoller.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DiceRoller.Dock = System.Windows.Forms.DockStyle.Top;
            this.DiceRoller.Location = new System.Drawing.Point(3, 26);
            this.DiceRoller.Name = "DiceRoller";
            this.DiceRoller.Size = new System.Drawing.Size(309, 23);
            this.DiceRoller.TabIndex = 1;
            this.DiceRoller.Text = "Dice Roller";
            this.DiceRoller.UseVisualStyleBackColor = true;
            this.DiceRoller.Click += new System.EventHandler(this.DiceRoller_Click);
            // 
            // SpellList
            // 
            this.SpellList.Dock = System.Windows.Forms.DockStyle.Top;
            this.SpellList.Location = new System.Drawing.Point(3, 49);
            this.SpellList.Name = "SpellList";
            this.SpellList.Size = new System.Drawing.Size(309, 23);
            this.SpellList.TabIndex = 2;
            this.SpellList.Text = "Spell List";
            this.SpellList.UseVisualStyleBackColor = true;
            // 
            // Notebook
            // 
            this.Notebook.Dock = System.Windows.Forms.DockStyle.Top;
            this.Notebook.Location = new System.Drawing.Point(3, 72);
            this.Notebook.Name = "Notebook";
            this.Notebook.Size = new System.Drawing.Size(309, 23);
            this.Notebook.TabIndex = 3;
            this.Notebook.Text = "Notebook";
            this.Notebook.UseVisualStyleBackColor = true;
            // 
            // OpeningScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 331);
            this.Controls.Add(this.tabControl1);
            this.Name = "OpeningScreen";
            this.Text = "DnD Tools";
            this.tabControl1.ResumeLayout(false);
            this.PlayerTools.ResumeLayout(false);
            this.PlayerTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PlayerTools;
        private System.Windows.Forms.TabPage DMTools;
        private System.Windows.Forms.Button CharacterCreator;
        private System.Windows.Forms.Button Notebook;
        private System.Windows.Forms.Button SpellList;
        private System.Windows.Forms.Button DiceRoller;
    }
}

