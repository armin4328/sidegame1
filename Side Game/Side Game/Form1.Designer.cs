namespace Side_Game
{
    partial class Form1
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
            this.prgHealth = new System.Windows.Forms.ProgressBar();
            this.labHealth = new System.Windows.Forms.Label();
            this.labMana = new System.Windows.Forms.Label();
            this.labXP = new System.Windows.Forms.Label();
            this.prgXP = new System.Windows.Forms.ProgressBar();
            this.prgMana = new System.Windows.Forms.ProgressBar();
            this.prgEnemyMana = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prgEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.labEnemy = new System.Windows.Forms.Label();
            this.labPlayer = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnDefend = new System.Windows.Forms.Button();
            this.btnTown = new System.Windows.Forms.Button();
            this.btnBattle = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prgHealth
            // 
            this.prgHealth.Location = new System.Drawing.Point(71, 506);
            this.prgHealth.Name = "prgHealth";
            this.prgHealth.Size = new System.Drawing.Size(272, 23);
            this.prgHealth.TabIndex = 0;
            this.prgHealth.Value = 100;
            // 
            // labHealth
            // 
            this.labHealth.AutoSize = true;
            this.labHealth.Location = new System.Drawing.Point(12, 506);
            this.labHealth.Name = "labHealth";
            this.labHealth.Size = new System.Drawing.Size(53, 13);
            this.labHealth.TabIndex = 2;
            this.labHealth.Text = "HEALTH:";
            // 
            // labMana
            // 
            this.labMana.AutoSize = true;
            this.labMana.Location = new System.Drawing.Point(24, 544);
            this.labMana.Name = "labMana";
            this.labMana.Size = new System.Drawing.Size(41, 13);
            this.labMana.TabIndex = 3;
            this.labMana.Text = "MANA:";
            // 
            // labXP
            // 
            this.labXP.AutoSize = true;
            this.labXP.Location = new System.Drawing.Point(41, 582);
            this.labXP.Name = "labXP";
            this.labXP.Size = new System.Drawing.Size(24, 13);
            this.labXP.TabIndex = 4;
            this.labXP.Text = "XP:";
            // 
            // prgXP
            // 
            this.prgXP.Location = new System.Drawing.Point(71, 582);
            this.prgXP.Name = "prgXP";
            this.prgXP.Size = new System.Drawing.Size(272, 23);
            this.prgXP.TabIndex = 6;
            // 
            // prgMana
            // 
            this.prgMana.Location = new System.Drawing.Point(71, 544);
            this.prgMana.Name = "prgMana";
            this.prgMana.Size = new System.Drawing.Size(272, 23);
            this.prgMana.TabIndex = 7;
            this.prgMana.Value = 100;
            // 
            // prgEnemyMana
            // 
            this.prgEnemyMana.Location = new System.Drawing.Point(751, 78);
            this.prgEnemyMana.Name = "prgEnemyMana";
            this.prgEnemyMana.Size = new System.Drawing.Size(272, 23);
            this.prgEnemyMana.TabIndex = 13;
            this.prgEnemyMana.Value = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "MANA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "HEALTH:";
            // 
            // prgEnemyHealth
            // 
            this.prgEnemyHealth.Location = new System.Drawing.Point(751, 40);
            this.prgEnemyHealth.Name = "prgEnemyHealth";
            this.prgEnemyHealth.Size = new System.Drawing.Size(272, 23);
            this.prgEnemyHealth.TabIndex = 8;
            this.prgEnemyHealth.Value = 100;
            // 
            // labEnemy
            // 
            this.labEnemy.AutoSize = true;
            this.labEnemy.Location = new System.Drawing.Point(865, 13);
            this.labEnemy.Name = "labEnemy";
            this.labEnemy.Size = new System.Drawing.Size(48, 13);
            this.labEnemy.TabIndex = 14;
            this.labEnemy.Text = "ZOMBIE";
            // 
            // labPlayer
            // 
            this.labPlayer.AutoSize = true;
            this.labPlayer.Location = new System.Drawing.Point(174, 476);
            this.labPlayer.Name = "labPlayer";
            this.labPlayer.Size = new System.Drawing.Size(49, 13);
            this.labPlayer.TabIndex = 15;
            this.labPlayer.Text = "PLAYER";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(368, 507);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(107, 99);
            this.btnAttack.TabIndex = 16;
            this.btnAttack.Text = "ATTACK";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnDefend
            // 
            this.btnDefend.Location = new System.Drawing.Point(505, 506);
            this.btnDefend.Name = "btnDefend";
            this.btnDefend.Size = new System.Drawing.Size(107, 99);
            this.btnDefend.TabIndex = 17;
            this.btnDefend.Text = "DEFEND";
            this.btnDefend.UseVisualStyleBackColor = true;
            // 
            // btnTown
            // 
            this.btnTown.Location = new System.Drawing.Point(779, 507);
            this.btnTown.Name = "btnTown";
            this.btnTown.Size = new System.Drawing.Size(107, 99);
            this.btnTown.TabIndex = 18;
            this.btnTown.Text = "TOWN";
            this.btnTown.UseVisualStyleBackColor = true;
            this.btnTown.Click += new System.EventHandler(this.btnTown_Click);
            // 
            // btnBattle
            // 
            this.btnBattle.Location = new System.Drawing.Point(642, 506);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(107, 99);
            this.btnBattle.TabIndex = 20;
            this.btnBattle.Text = "ENTER BATTLE";
            this.btnBattle.UseVisualStyleBackColor = true;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(916, 507);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(107, 99);
            this.btnStats.TabIndex = 21;
            this.btnStats.Text = "STATS";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 633);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnBattle);
            this.Controls.Add(this.btnTown);
            this.Controls.Add(this.btnDefend);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.labPlayer);
            this.Controls.Add(this.labEnemy);
            this.Controls.Add(this.prgEnemyMana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prgEnemyHealth);
            this.Controls.Add(this.prgMana);
            this.Controls.Add(this.prgXP);
            this.Controls.Add(this.labXP);
            this.Controls.Add(this.labMana);
            this.Controls.Add(this.labHealth);
            this.Controls.Add(this.prgHealth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgHealth;
        private System.Windows.Forms.Label labHealth;
        private System.Windows.Forms.Label labMana;
        private System.Windows.Forms.Label labXP;
        private System.Windows.Forms.ProgressBar prgXP;
        private System.Windows.Forms.ProgressBar prgMana;
        private System.Windows.Forms.ProgressBar prgEnemyMana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar prgEnemyHealth;
        private System.Windows.Forms.Label labEnemy;
        private System.Windows.Forms.Label labPlayer;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnDefend;
        private System.Windows.Forms.Button btnTown;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.Button btnStats;
    }
}

