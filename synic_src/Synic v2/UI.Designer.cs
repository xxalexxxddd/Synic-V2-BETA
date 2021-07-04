
namespace Synic_v2
{
    partial class UI
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
            this.bar2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.bar1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.settingsButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.macroButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.macroPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.cpsTrackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.cpsLabel = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.ppmMacroCB = new Guna.UI2.WinForms.Guna2CheckBox();
            this.enabledCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.bindInfo = new System.Windows.Forms.Label();
            this.visualLabel1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindsButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bindsPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.disableBinds = new Guna.UI2.WinForms.Guna2CheckBox();
            this.minimizeButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.CloseButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GradientPanel3.SuspendLayout();
            this.macroPanel.SuspendLayout();
            this.bindsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.FillColor = System.Drawing.Color.DeepPink;
            this.bar2.FillColor2 = System.Drawing.Color.Fuchsia;
            this.bar2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bar2.Location = new System.Drawing.Point(0, 0);
            this.bar2.Name = "bar2";
            this.bar2.ShadowDecoration.Parent = this.bar2;
            this.bar2.Size = new System.Drawing.Size(1, 450);
            this.bar2.TabIndex = 0;
            this.bar2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.All_MouseDown);
            this.bar2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.All_MouseMove);
            // 
            // bar1
            // 
            this.bar1.FillColor = System.Drawing.Color.DeepPink;
            this.bar1.FillColor2 = System.Drawing.Color.Fuchsia;
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.ShadowDecoration.Parent = this.bar1;
            this.bar1.Size = new System.Drawing.Size(750, 1);
            this.bar1.TabIndex = 1;
            this.bar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.All_MouseDown);
            this.bar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.All_MouseMove);
            // 
            // settingsButton
            // 
            this.settingsButton.Animated = true;
            this.settingsButton.AnimatedGIF = true;
            this.settingsButton.CheckedState.Parent = this.settingsButton;
            this.settingsButton.CustomImages.Parent = this.settingsButton;
            this.settingsButton.FillColor = System.Drawing.Color.DeepPink;
            this.settingsButton.FillColor2 = System.Drawing.Color.Fuchsia;
            this.settingsButton.Font = new System.Drawing.Font("Lato", 12.5F, System.Drawing.FontStyle.Bold);
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.HoverState.FillColor = System.Drawing.Color.Fuchsia;
            this.settingsButton.HoverState.FillColor2 = System.Drawing.Color.DeepPink;
            this.settingsButton.HoverState.Parent = this.settingsButton;
            this.settingsButton.Location = new System.Drawing.Point(0, 365);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.ShadowDecoration.Parent = this.settingsButton;
            this.settingsButton.Size = new System.Drawing.Size(100, 35);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.Text = "Opcje";
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.Controls.Add(this.bindsButton);
            this.guna2GradientPanel3.Controls.Add(this.macroButton);
            this.guna2GradientPanel3.Controls.Add(this.settingsButton);
            this.guna2GradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2GradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.guna2GradientPanel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel3.Location = new System.Drawing.Point(10, 40);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.ShadowDecoration.Parent = this.guna2GradientPanel3;
            this.guna2GradientPanel3.Size = new System.Drawing.Size(100, 400);
            this.guna2GradientPanel3.TabIndex = 3;
            this.guna2GradientPanel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.All_MouseDown);
            this.guna2GradientPanel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.All_MouseMove);
            // 
            // macroButton
            // 
            this.macroButton.Animated = true;
            this.macroButton.AnimatedGIF = true;
            this.macroButton.CheckedState.Parent = this.macroButton;
            this.macroButton.CustomImages.Parent = this.macroButton;
            this.macroButton.FillColor = System.Drawing.Color.DeepPink;
            this.macroButton.FillColor2 = System.Drawing.Color.Fuchsia;
            this.macroButton.Font = new System.Drawing.Font("Lato", 12.5F, System.Drawing.FontStyle.Bold);
            this.macroButton.ForeColor = System.Drawing.Color.White;
            this.macroButton.HoverState.FillColor = System.Drawing.Color.Fuchsia;
            this.macroButton.HoverState.FillColor2 = System.Drawing.Color.DeepPink;
            this.macroButton.HoverState.Parent = this.macroButton;
            this.macroButton.Location = new System.Drawing.Point(0, 0);
            this.macroButton.Name = "macroButton";
            this.macroButton.ShadowDecoration.Parent = this.macroButton;
            this.macroButton.Size = new System.Drawing.Size(100, 35);
            this.macroButton.TabIndex = 2;
            this.macroButton.Text = "Makro";
            this.macroButton.Click += new System.EventHandler(this.macroButton_Click);
            // 
            // macroPanel
            // 
            this.macroPanel.Controls.Add(this.bindInfo);
            this.macroPanel.Controls.Add(this.enabledCheckBox);
            this.macroPanel.Controls.Add(this.ppmMacroCB);
            this.macroPanel.Controls.Add(this.cpsLabel);
            this.macroPanel.Controls.Add(this.cpsTrackBar);
            this.macroPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.macroPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.macroPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.macroPanel.Location = new System.Drawing.Point(115, 40);
            this.macroPanel.Name = "macroPanel";
            this.macroPanel.ShadowDecoration.Parent = this.macroPanel;
            this.macroPanel.Size = new System.Drawing.Size(625, 400);
            this.macroPanel.TabIndex = 4;
            this.macroPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.All_MouseDown);
            this.macroPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.All_MouseMove);
            // 
            // cpsTrackBar
            // 
            this.cpsTrackBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cpsTrackBar.HoverState.Parent = this.cpsTrackBar;
            this.cpsTrackBar.IndicateFocus = false;
            this.cpsTrackBar.LargeChange = 1;
            this.cpsTrackBar.Location = new System.Drawing.Point(96, 3);
            this.cpsTrackBar.Maximum = 20;
            this.cpsTrackBar.Minimum = 1;
            this.cpsTrackBar.MouseWheelBarPartitions = 1;
            this.cpsTrackBar.Name = "cpsTrackBar";
            this.cpsTrackBar.Size = new System.Drawing.Size(526, 23);
            this.cpsTrackBar.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.cpsTrackBar.TabIndex = 0;
            this.cpsTrackBar.ThumbColor = System.Drawing.Color.DeepPink;
            this.cpsTrackBar.Value = 13;
            this.cpsTrackBar.ValueChanged += new System.EventHandler(this.cpsTrackBar_ValueChanged);
            // 
            // cpsLabel
            // 
            this.cpsLabel.ForeColor = System.Drawing.Color.White;
            this.cpsLabel.Location = new System.Drawing.Point(3, 3);
            this.cpsLabel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.cpsLabel.Name = "cpsLabel";
            this.cpsLabel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.cpsLabel.Outline = false;
            this.cpsLabel.OutlineColor = System.Drawing.Color.Red;
            this.cpsLabel.OutlineLocation = new System.Drawing.Point(0, 0);
            this.cpsLabel.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cpsLabel.ReflectionSpacing = 0;
            this.cpsLabel.ShadowColor = System.Drawing.Color.Black;
            this.cpsLabel.ShadowDirection = 315;
            this.cpsLabel.ShadowLocation = new System.Drawing.Point(0, 0);
            this.cpsLabel.ShadowOpacity = 100;
            this.cpsLabel.Size = new System.Drawing.Size(87, 23);
            this.cpsLabel.TabIndex = 1;
            this.cpsLabel.Text = "CPSy (13):";
            this.cpsLabel.TextAlignment = System.Drawing.StringAlignment.Near;
            this.cpsLabel.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.cpsLabel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.cpsLabel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cpsLabel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cpsLabel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cpsLabel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cpsLabel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.cpsLabel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cpsLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.All_MouseDown);
            this.cpsLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.All_MouseMove);
            // 
            // ppmMacroCB
            // 
            this.ppmMacroCB.Animated = true;
            this.ppmMacroCB.AutoSize = true;
            this.ppmMacroCB.CheckedState.BorderColor = System.Drawing.Color.DeepPink;
            this.ppmMacroCB.CheckedState.BorderRadius = 0;
            this.ppmMacroCB.CheckedState.BorderThickness = 0;
            this.ppmMacroCB.CheckedState.FillColor = System.Drawing.Color.DeepPink;
            this.ppmMacroCB.Location = new System.Drawing.Point(12, 32);
            this.ppmMacroCB.Name = "ppmMacroCB";
            this.ppmMacroCB.Size = new System.Drawing.Size(329, 26);
            this.ppmMacroCB.TabIndex = 2;
            this.ppmMacroCB.Text = "Makro na PPM (prawy przycisk myszy)?";
            this.ppmMacroCB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ppmMacroCB.UncheckedState.BorderRadius = 0;
            this.ppmMacroCB.UncheckedState.BorderThickness = 0;
            this.ppmMacroCB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ppmMacroCB.CheckedChanged += new System.EventHandler(this.ppmMacroCB_CheckedChanged);
            // 
            // enabledCheckBox
            // 
            this.enabledCheckBox.Animated = true;
            this.enabledCheckBox.AutoSize = true;
            this.enabledCheckBox.Checked = true;
            this.enabledCheckBox.CheckedState.BorderColor = System.Drawing.Color.DeepPink;
            this.enabledCheckBox.CheckedState.BorderRadius = 0;
            this.enabledCheckBox.CheckedState.BorderThickness = 0;
            this.enabledCheckBox.CheckedState.FillColor = System.Drawing.Color.DeepPink;
            this.enabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enabledCheckBox.Location = new System.Drawing.Point(492, 349);
            this.enabledCheckBox.Name = "enabledCheckBox";
            this.enabledCheckBox.Size = new System.Drawing.Size(113, 26);
            this.enabledCheckBox.TabIndex = 3;
            this.enabledCheckBox.Text = "Włączone?";
            this.enabledCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.enabledCheckBox.UncheckedState.BorderRadius = 0;
            this.enabledCheckBox.UncheckedState.BorderThickness = 0;
            this.enabledCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.enabledCheckBox.Visible = false;
            this.enabledCheckBox.CheckedChanged += new System.EventHandler(this.enabledCheckBox_CheckedChanged);
            // 
            // bindInfo
            // 
            this.bindInfo.AutoSize = true;
            this.bindInfo.Location = new System.Drawing.Point(8, 61);
            this.bindInfo.Name = "bindInfo";
            this.bindInfo.Size = new System.Drawing.Size(170, 22);
            this.bindInfo.TabIndex = 4;
            this.bindInfo.Text = "bind: R (tymczasowe)";
            this.bindInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.All_MouseDown);
            this.bindInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.All_MouseMove);
            // 
            // visualLabel1
            // 
            this.visualLabel1.ForeColor = System.Drawing.Color.White;
            this.visualLabel1.Location = new System.Drawing.Point(10, 8);
            this.visualLabel1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel1.Name = "visualLabel1";
            this.visualLabel1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel1.Outline = false;
            this.visualLabel1.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel1.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel1.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.ReflectionSpacing = 0;
            this.visualLabel1.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel1.ShadowDirection = 315;
            this.visualLabel1.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel1.ShadowOpacity = 100;
            this.visualLabel1.Size = new System.Drawing.Size(100, 25);
            this.visualLabel1.TabIndex = 5;
            this.visualLabel1.Text = "Synic (beta)";
            this.visualLabel1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.visualLabel1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualLabel1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.All_MouseDown);
            this.visualLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.All_MouseMove);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgTask_DoWork);
            // 
            // bindsButton
            // 
            this.bindsButton.Animated = true;
            this.bindsButton.AnimatedGIF = true;
            this.bindsButton.CheckedState.Parent = this.bindsButton;
            this.bindsButton.CustomImages.Parent = this.bindsButton;
            this.bindsButton.FillColor = System.Drawing.Color.DeepPink;
            this.bindsButton.FillColor2 = System.Drawing.Color.Fuchsia;
            this.bindsButton.Font = new System.Drawing.Font("Lato", 12.5F, System.Drawing.FontStyle.Bold);
            this.bindsButton.ForeColor = System.Drawing.Color.White;
            this.bindsButton.HoverState.FillColor = System.Drawing.Color.Fuchsia;
            this.bindsButton.HoverState.FillColor2 = System.Drawing.Color.DeepPink;
            this.bindsButton.HoverState.Parent = this.bindsButton;
            this.bindsButton.Location = new System.Drawing.Point(0, 37);
            this.bindsButton.Name = "bindsButton";
            this.bindsButton.ShadowDecoration.Parent = this.bindsButton;
            this.bindsButton.Size = new System.Drawing.Size(100, 35);
            this.bindsButton.TabIndex = 3;
            this.bindsButton.Text = "Bindy";
            this.bindsButton.Click += new System.EventHandler(this.bindsButton_Click);
            // 
            // bindsPanel
            // 
            this.bindsPanel.Controls.Add(this.disableBinds);
            this.bindsPanel.Controls.Add(this.label3);
            this.bindsPanel.Controls.Add(this.label2);
            this.bindsPanel.Controls.Add(this.label1);
            this.bindsPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.bindsPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.bindsPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bindsPanel.Location = new System.Drawing.Point(115, 40);
            this.bindsPanel.Name = "bindsPanel";
            this.bindsPanel.ShadowDecoration.Parent = this.bindsPanel;
            this.bindsPanel.Size = new System.Drawing.Size(625, 400);
            this.bindsPanel.TabIndex = 5;
            this.bindsPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wedka/sniezki: k (tymczasowe)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Punch: v (tymczasowe)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(406, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kopanie (tekst tymczasowy): L (stoniarki w gore 5x2)";
            this.label3.Visible = false;
            // 
            // disableBinds
            // 
            this.disableBinds.Animated = true;
            this.disableBinds.AutoSize = true;
            this.disableBinds.Checked = true;
            this.disableBinds.CheckedState.BorderColor = System.Drawing.Color.DeepPink;
            this.disableBinds.CheckedState.BorderRadius = 0;
            this.disableBinds.CheckedState.BorderThickness = 0;
            this.disableBinds.CheckedState.FillColor = System.Drawing.Color.DeepPink;
            this.disableBinds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.disableBinds.Location = new System.Drawing.Point(500, 3);
            this.disableBinds.Name = "disableBinds";
            this.disableBinds.Size = new System.Drawing.Size(122, 26);
            this.disableBinds.TabIndex = 5;
            this.disableBinds.Text = "Wlacz bindy";
            this.disableBinds.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.disableBinds.UncheckedState.BorderRadius = 0;
            this.disableBinds.UncheckedState.BorderThickness = 0;
            this.disableBinds.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.disableBinds.CheckedChanged += new System.EventHandler(this.disableBinds_CheckedChanged);
            // 
            // minimizeButton
            // 
            this.minimizeButton.AnimatedGIF = true;
            this.minimizeButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.minimizeButton.CheckedState.Parent = this.minimizeButton;
            this.minimizeButton.HoverState.Image = global::Synic_v2.Properties.Resources.minimize_color;
            this.minimizeButton.HoverState.ImageSize = new System.Drawing.Size(28, 28);
            this.minimizeButton.HoverState.Parent = this.minimizeButton;
            this.minimizeButton.Image = global::Synic_v2.Properties.Resources.minimize_white;
            this.minimizeButton.ImageRotate = 0F;
            this.minimizeButton.ImageSize = new System.Drawing.Size(28, 28);
            this.minimizeButton.Location = new System.Drawing.Point(684, 8);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.PressedState.Image = global::Synic_v2.Properties.Resources.minimize_color;
            this.minimizeButton.PressedState.ImageSize = new System.Drawing.Size(28, 28);
            this.minimizeButton.PressedState.Parent = this.minimizeButton;
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.TabIndex = 6;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AnimatedGIF = true;
            this.CloseButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.CloseButton.CheckedState.Parent = this.CloseButton;
            this.CloseButton.HoverState.Image = global::Synic_v2.Properties.Resources.close_color;
            this.CloseButton.HoverState.ImageSize = new System.Drawing.Size(28, 28);
            this.CloseButton.HoverState.Parent = this.CloseButton;
            this.CloseButton.Image = global::Synic_v2.Properties.Resources.close_white;
            this.CloseButton.ImageRotate = 0F;
            this.CloseButton.ImageSize = new System.Drawing.Size(28, 28);
            this.CloseButton.Location = new System.Drawing.Point(712, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.PressedState.Image = global::Synic_v2.Properties.Resources.close_color;
            this.CloseButton.PressedState.ImageSize = new System.Drawing.Size(28, 28);
            this.CloseButton.PressedState.Parent = this.CloseButton;
            this.CloseButton.Size = new System.Drawing.Size(25, 25);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // UI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.visualLabel1);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.bar2);
            this.Controls.Add(this.guna2GradientPanel3);
            this.Controls.Add(this.macroPanel);
            this.Controls.Add(this.bindsPanel);
            this.Font = new System.Drawing.Font("Lato Light", 13F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Synic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UI_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.All_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.All_MouseMove);
            this.guna2GradientPanel3.ResumeLayout(false);
            this.macroPanel.ResumeLayout(false);
            this.macroPanel.PerformLayout();
            this.bindsPanel.ResumeLayout(false);
            this.bindsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel bar2;
        private Guna.UI2.WinForms.Guna2GradientPanel bar1;
        private Guna.UI2.WinForms.Guna2GradientButton settingsButton;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private Guna.UI2.WinForms.Guna2GradientButton macroButton;
        private Guna.UI2.WinForms.Guna2GradientPanel macroPanel;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel cpsLabel;
        private Guna.UI2.WinForms.Guna2TrackBar cpsTrackBar;
        private Guna.UI2.WinForms.Guna2CheckBox ppmMacroCB;
        private Guna.UI2.WinForms.Guna2CheckBox enabledCheckBox;
        private System.Windows.Forms.Label bindInfo;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel1;
        private Guna.UI2.WinForms.Guna2ImageButton CloseButton;
        private Guna.UI2.WinForms.Guna2ImageButton minimizeButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2GradientButton bindsButton;
        private Guna.UI2.WinForms.Guna2GradientPanel bindsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CheckBox disableBinds;
    }
}

