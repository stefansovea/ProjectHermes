namespace ProjectHermes
{
    partial class FormElev
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
            this.pictureBoxLogoElev = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBoxHeyStudent = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tabControlElev = new Guna.UI2.WinForms.Guna2TabControl();
            this.homePage = new System.Windows.Forms.TabPage();
            this.lblBuildInfo = new System.Windows.Forms.Label();
            this.lblTiltluHomepage = new System.Windows.Forms.Label();
            this.labelHomepage = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.avizier = new System.Windows.Forms.TabPage();
            this.lblAvizierTitlu = new System.Windows.Forms.Label();
            this.solicitareActe = new System.Windows.Forms.TabPage();
            this.lblSolicitareTitlu = new System.Windows.Forms.Label();
            this.academic = new System.Windows.Forms.TabPage();
            this.lblAcademicTitlu = new System.Windows.Forms.Label();
            this.situatieScolara = new System.Windows.Forms.TabPage();
            this.lblSituatieScolaraTitlu = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.TabPage();
            this.lblContactTitlu = new System.Windows.Forms.Label();
            this.detaliiPersonale = new System.Windows.Forms.TabPage();
            this.lblDetaliiPersonaleTitlu = new System.Windows.Forms.Label();
            this.btnAvizier = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnSolicitareActe = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnAcademic = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnSituatieScolara = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnContact = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnDetaliiPersonale = new Guna.UI2.WinForms.Guna2TileButton();
            this.elevMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.elevClose = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoElev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeyStudent)).BeginInit();
            this.tabControlElev.SuspendLayout();
            this.homePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.avizier.SuspendLayout();
            this.solicitareActe.SuspendLayout();
            this.academic.SuspendLayout();
            this.situatieScolara.SuspendLayout();
            this.contact.SuspendLayout();
            this.detaliiPersonale.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogoElev
            // 
            this.pictureBoxLogoElev.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogoElev.Image = global::ProjectHermes.Properties.Resources.Logo_Final_2;
            this.pictureBoxLogoElev.ImageRotate = 0F;
            this.pictureBoxLogoElev.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogoElev.Name = "pictureBoxLogoElev";
            this.pictureBoxLogoElev.ShadowDecoration.Parent = this.pictureBoxLogoElev;
            this.pictureBoxLogoElev.Size = new System.Drawing.Size(239, 125);
            this.pictureBoxLogoElev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoElev.TabIndex = 0;
            this.pictureBoxLogoElev.TabStop = false;
            this.pictureBoxLogoElev.UseTransparentBackground = true;
            this.pictureBoxLogoElev.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // pictureBoxHeyStudent
            // 
            this.pictureBoxHeyStudent.Image = global::ProjectHermes.Properties.Resources.WS2;
            this.pictureBoxHeyStudent.ImageRotate = 0F;
            this.pictureBoxHeyStudent.Location = new System.Drawing.Point(0, 131);
            this.pictureBoxHeyStudent.Name = "pictureBoxHeyStudent";
            this.pictureBoxHeyStudent.ShadowDecoration.Parent = this.pictureBoxHeyStudent;
            this.pictureBoxHeyStudent.Size = new System.Drawing.Size(242, 114);
            this.pictureBoxHeyStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHeyStudent.TabIndex = 1;
            this.pictureBoxHeyStudent.TabStop = false;
            // 
            // tabControlElev
            // 
            this.tabControlElev.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControlElev.Controls.Add(this.homePage);
            this.tabControlElev.Controls.Add(this.avizier);
            this.tabControlElev.Controls.Add(this.solicitareActe);
            this.tabControlElev.Controls.Add(this.academic);
            this.tabControlElev.Controls.Add(this.situatieScolara);
            this.tabControlElev.Controls.Add(this.contact);
            this.tabControlElev.Controls.Add(this.detaliiPersonale);
            this.tabControlElev.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControlElev.Location = new System.Drawing.Point(241, 30);
            this.tabControlElev.Name = "tabControlElev";
            this.tabControlElev.SelectedIndex = 0;
            this.tabControlElev.Size = new System.Drawing.Size(1157, 821);
            this.tabControlElev.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlElev.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControlElev.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlElev.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControlElev.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControlElev.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlElev.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControlElev.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlElev.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControlElev.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControlElev.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlElev.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabControlElev.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlElev.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControlElev.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabControlElev.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabControlElev.TabIndex = 2;
            this.tabControlElev.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControlElev.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.VerticalRight;
            // 
            // homePage
            // 
            this.homePage.BackColor = System.Drawing.Color.Black;
            this.homePage.Controls.Add(this.lblBuildInfo);
            this.homePage.Controls.Add(this.lblTiltluHomepage);
            this.homePage.Controls.Add(this.labelHomepage);
            this.homePage.Controls.Add(this.guna2CirclePictureBox1);
            this.homePage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePage.Location = new System.Drawing.Point(4, 4);
            this.homePage.Name = "homePage";
            this.homePage.Padding = new System.Windows.Forms.Padding(3);
            this.homePage.Size = new System.Drawing.Size(969, 813);
            this.homePage.TabIndex = 0;
            this.homePage.Text = "HomePage";
            // 
            // lblBuildInfo
            // 
            this.lblBuildInfo.AutoSize = true;
            this.lblBuildInfo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildInfo.ForeColor = System.Drawing.Color.White;
            this.lblBuildInfo.Location = new System.Drawing.Point(405, 679);
            this.lblBuildInfo.Name = "lblBuildInfo";
            this.lblBuildInfo.Size = new System.Drawing.Size(157, 69);
            this.lblBuildInfo.TabIndex = 3;
            this.lblBuildInfo.Text = "Project Hermes\r\nBuild v1.0.1\r\n2021";
            this.lblBuildInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTiltluHomepage
            // 
            this.lblTiltluHomepage.AutoSize = true;
            this.lblTiltluHomepage.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiltluHomepage.ForeColor = System.Drawing.Color.White;
            this.lblTiltluHomepage.Location = new System.Drawing.Point(400, 50);
            this.lblTiltluHomepage.Name = "lblTiltluHomepage";
            this.lblTiltluHomepage.Size = new System.Drawing.Size(171, 35);
            this.lblTiltluHomepage.TabIndex = 2;
            this.lblTiltluHomepage.Text = "HomePage";
            this.lblTiltluHomepage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHomepage
            // 
            this.labelHomepage.AutoSize = true;
            this.labelHomepage.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomepage.ForeColor = System.Drawing.Color.White;
            this.labelHomepage.Location = new System.Drawing.Point(313, 346);
            this.labelHomepage.Name = "labelHomepage";
            this.labelHomepage.Size = new System.Drawing.Size(358, 105);
            this.labelHomepage.TabIndex = 1;
            this.labelHomepage.Text = "*Insert Student Name*\r\nClasa X\r\nScoala Y";
            this.labelHomepage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::ProjectHermes.Properties.Resources.LOGO;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(363, 93);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(250, 250);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // avizier
            // 
            this.avizier.BackColor = System.Drawing.Color.Black;
            this.avizier.Controls.Add(this.lblAvizierTitlu);
            this.avizier.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avizier.Location = new System.Drawing.Point(4, 4);
            this.avizier.Name = "avizier";
            this.avizier.Padding = new System.Windows.Forms.Padding(3);
            this.avizier.Size = new System.Drawing.Size(969, 813);
            this.avizier.TabIndex = 1;
            this.avizier.Text = "Avizier";
            // 
            // lblAvizierTitlu
            // 
            this.lblAvizierTitlu.AutoSize = true;
            this.lblAvizierTitlu.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvizierTitlu.ForeColor = System.Drawing.Color.White;
            this.lblAvizierTitlu.Location = new System.Drawing.Point(400, 50);
            this.lblAvizierTitlu.Name = "lblAvizierTitlu";
            this.lblAvizierTitlu.Size = new System.Drawing.Size(115, 35);
            this.lblAvizierTitlu.TabIndex = 3;
            this.lblAvizierTitlu.Text = "Avizier";
            this.lblAvizierTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // solicitareActe
            // 
            this.solicitareActe.BackColor = System.Drawing.Color.Black;
            this.solicitareActe.Controls.Add(this.lblSolicitareTitlu);
            this.solicitareActe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solicitareActe.Location = new System.Drawing.Point(4, 4);
            this.solicitareActe.Name = "solicitareActe";
            this.solicitareActe.Padding = new System.Windows.Forms.Padding(3);
            this.solicitareActe.Size = new System.Drawing.Size(969, 813);
            this.solicitareActe.TabIndex = 2;
            this.solicitareActe.Text = "Solicitare Acte";
            // 
            // lblSolicitareTitlu
            // 
            this.lblSolicitareTitlu.AutoSize = true;
            this.lblSolicitareTitlu.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitareTitlu.ForeColor = System.Drawing.Color.White;
            this.lblSolicitareTitlu.Location = new System.Drawing.Point(400, 50);
            this.lblSolicitareTitlu.Name = "lblSolicitareTitlu";
            this.lblSolicitareTitlu.Size = new System.Drawing.Size(225, 35);
            this.lblSolicitareTitlu.TabIndex = 3;
            this.lblSolicitareTitlu.Text = "Solicitare Acte";
            this.lblSolicitareTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // academic
            // 
            this.academic.BackColor = System.Drawing.Color.Black;
            this.academic.Controls.Add(this.lblAcademicTitlu);
            this.academic.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.academic.Location = new System.Drawing.Point(4, 4);
            this.academic.Name = "academic";
            this.academic.Size = new System.Drawing.Size(969, 813);
            this.academic.TabIndex = 3;
            this.academic.Text = "Academic";
            // 
            // lblAcademicTitlu
            // 
            this.lblAcademicTitlu.AutoSize = true;
            this.lblAcademicTitlu.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicTitlu.ForeColor = System.Drawing.Color.White;
            this.lblAcademicTitlu.Location = new System.Drawing.Point(400, 50);
            this.lblAcademicTitlu.Name = "lblAcademicTitlu";
            this.lblAcademicTitlu.Size = new System.Drawing.Size(154, 35);
            this.lblAcademicTitlu.TabIndex = 3;
            this.lblAcademicTitlu.Text = "Academic";
            this.lblAcademicTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // situatieScolara
            // 
            this.situatieScolara.BackColor = System.Drawing.Color.Black;
            this.situatieScolara.Controls.Add(this.lblSituatieScolaraTitlu);
            this.situatieScolara.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situatieScolara.Location = new System.Drawing.Point(4, 4);
            this.situatieScolara.Name = "situatieScolara";
            this.situatieScolara.Size = new System.Drawing.Size(969, 813);
            this.situatieScolara.TabIndex = 4;
            this.situatieScolara.Text = "Situatie Scolara";
            // 
            // lblSituatieScolaraTitlu
            // 
            this.lblSituatieScolaraTitlu.AutoSize = true;
            this.lblSituatieScolaraTitlu.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituatieScolaraTitlu.ForeColor = System.Drawing.Color.White;
            this.lblSituatieScolaraTitlu.Location = new System.Drawing.Point(400, 50);
            this.lblSituatieScolaraTitlu.Name = "lblSituatieScolaraTitlu";
            this.lblSituatieScolaraTitlu.Size = new System.Drawing.Size(244, 35);
            this.lblSituatieScolaraTitlu.TabIndex = 3;
            this.lblSituatieScolaraTitlu.Text = "Situatie Scolara";
            this.lblSituatieScolaraTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contact
            // 
            this.contact.BackColor = System.Drawing.Color.Black;
            this.contact.Controls.Add(this.lblContactTitlu);
            this.contact.Location = new System.Drawing.Point(4, 4);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(969, 813);
            this.contact.TabIndex = 5;
            this.contact.Text = "Contact";
            // 
            // lblContactTitlu
            // 
            this.lblContactTitlu.AutoSize = true;
            this.lblContactTitlu.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactTitlu.ForeColor = System.Drawing.Color.White;
            this.lblContactTitlu.Location = new System.Drawing.Point(400, 50);
            this.lblContactTitlu.Name = "lblContactTitlu";
            this.lblContactTitlu.Size = new System.Drawing.Size(127, 35);
            this.lblContactTitlu.TabIndex = 3;
            this.lblContactTitlu.Text = "Contact";
            this.lblContactTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // detaliiPersonale
            // 
            this.detaliiPersonale.BackColor = System.Drawing.Color.Black;
            this.detaliiPersonale.Controls.Add(this.lblDetaliiPersonaleTitlu);
            this.detaliiPersonale.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detaliiPersonale.Location = new System.Drawing.Point(4, 4);
            this.detaliiPersonale.Name = "detaliiPersonale";
            this.detaliiPersonale.Size = new System.Drawing.Size(969, 813);
            this.detaliiPersonale.TabIndex = 6;
            this.detaliiPersonale.Text = "Detalii Personale";
            // 
            // lblDetaliiPersonaleTitlu
            // 
            this.lblDetaliiPersonaleTitlu.AutoSize = true;
            this.lblDetaliiPersonaleTitlu.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetaliiPersonaleTitlu.ForeColor = System.Drawing.Color.White;
            this.lblDetaliiPersonaleTitlu.Location = new System.Drawing.Point(400, 50);
            this.lblDetaliiPersonaleTitlu.Name = "lblDetaliiPersonaleTitlu";
            this.lblDetaliiPersonaleTitlu.Size = new System.Drawing.Size(263, 35);
            this.lblDetaliiPersonaleTitlu.TabIndex = 3;
            this.lblDetaliiPersonaleTitlu.Text = "Detalii Personale";
            this.lblDetaliiPersonaleTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAvizier
            // 
            this.btnAvizier.Animated = true;
            this.btnAvizier.CheckedState.Parent = this.btnAvizier;
            this.btnAvizier.CustomImages.Parent = this.btnAvizier;
            this.btnAvizier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAvizier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAvizier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAvizier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAvizier.DisabledState.Parent = this.btnAvizier;
            this.btnAvizier.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnAvizier.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvizier.ForeColor = System.Drawing.Color.White;
            this.btnAvizier.HoverState.Parent = this.btnAvizier;
            this.btnAvizier.Location = new System.Drawing.Point(0, 239);
            this.btnAvizier.Name = "btnAvizier";
            this.btnAvizier.ShadowDecoration.Parent = this.btnAvizier;
            this.btnAvizier.Size = new System.Drawing.Size(239, 97);
            this.btnAvizier.TabIndex = 3;
            this.btnAvizier.Text = "Avizier";
            this.btnAvizier.Click += new System.EventHandler(this.btnAvizier_Click);
            // 
            // btnSolicitareActe
            // 
            this.btnSolicitareActe.Animated = true;
            this.btnSolicitareActe.CheckedState.Parent = this.btnSolicitareActe;
            this.btnSolicitareActe.CustomImages.Parent = this.btnSolicitareActe;
            this.btnSolicitareActe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSolicitareActe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSolicitareActe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSolicitareActe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSolicitareActe.DisabledState.Parent = this.btnSolicitareActe;
            this.btnSolicitareActe.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnSolicitareActe.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitareActe.ForeColor = System.Drawing.Color.White;
            this.btnSolicitareActe.HoverState.Parent = this.btnSolicitareActe;
            this.btnSolicitareActe.Location = new System.Drawing.Point(0, 342);
            this.btnSolicitareActe.Name = "btnSolicitareActe";
            this.btnSolicitareActe.ShadowDecoration.Parent = this.btnSolicitareActe;
            this.btnSolicitareActe.Size = new System.Drawing.Size(239, 97);
            this.btnSolicitareActe.TabIndex = 4;
            this.btnSolicitareActe.Text = "Solicitare Acte";
            this.btnSolicitareActe.Click += new System.EventHandler(this.btnSolicitareActe_Click);
            // 
            // btnAcademic
            // 
            this.btnAcademic.Animated = true;
            this.btnAcademic.CheckedState.Parent = this.btnAcademic;
            this.btnAcademic.CustomImages.Parent = this.btnAcademic;
            this.btnAcademic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAcademic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAcademic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAcademic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAcademic.DisabledState.Parent = this.btnAcademic;
            this.btnAcademic.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnAcademic.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcademic.ForeColor = System.Drawing.Color.White;
            this.btnAcademic.HoverState.Parent = this.btnAcademic;
            this.btnAcademic.Location = new System.Drawing.Point(0, 445);
            this.btnAcademic.Name = "btnAcademic";
            this.btnAcademic.ShadowDecoration.Parent = this.btnAcademic;
            this.btnAcademic.Size = new System.Drawing.Size(239, 97);
            this.btnAcademic.TabIndex = 5;
            this.btnAcademic.Text = "Academic";
            this.btnAcademic.Click += new System.EventHandler(this.guna2TileButton3_Click);
            // 
            // btnSituatieScolara
            // 
            this.btnSituatieScolara.Animated = true;
            this.btnSituatieScolara.CheckedState.Parent = this.btnSituatieScolara;
            this.btnSituatieScolara.CustomImages.Parent = this.btnSituatieScolara;
            this.btnSituatieScolara.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSituatieScolara.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSituatieScolara.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSituatieScolara.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSituatieScolara.DisabledState.Parent = this.btnSituatieScolara;
            this.btnSituatieScolara.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnSituatieScolara.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSituatieScolara.ForeColor = System.Drawing.Color.White;
            this.btnSituatieScolara.HoverState.Parent = this.btnSituatieScolara;
            this.btnSituatieScolara.Location = new System.Drawing.Point(0, 548);
            this.btnSituatieScolara.Name = "btnSituatieScolara";
            this.btnSituatieScolara.ShadowDecoration.Parent = this.btnSituatieScolara;
            this.btnSituatieScolara.Size = new System.Drawing.Size(239, 97);
            this.btnSituatieScolara.TabIndex = 6;
            this.btnSituatieScolara.Text = "Situatie Scolara";
            this.btnSituatieScolara.Click += new System.EventHandler(this.btnSituatieScolara_Click);
            // 
            // btnContact
            // 
            this.btnContact.Animated = true;
            this.btnContact.CheckedState.Parent = this.btnContact;
            this.btnContact.CustomImages.Parent = this.btnContact;
            this.btnContact.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnContact.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnContact.DisabledState.Parent = this.btnContact;
            this.btnContact.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnContact.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.ForeColor = System.Drawing.Color.White;
            this.btnContact.HoverState.Parent = this.btnContact;
            this.btnContact.Location = new System.Drawing.Point(0, 651);
            this.btnContact.Name = "btnContact";
            this.btnContact.ShadowDecoration.Parent = this.btnContact;
            this.btnContact.Size = new System.Drawing.Size(239, 97);
            this.btnContact.TabIndex = 7;
            this.btnContact.Text = "Contact";
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnDetaliiPersonale
            // 
            this.btnDetaliiPersonale.Animated = true;
            this.btnDetaliiPersonale.CheckedState.Parent = this.btnDetaliiPersonale;
            this.btnDetaliiPersonale.CustomImages.Parent = this.btnDetaliiPersonale;
            this.btnDetaliiPersonale.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetaliiPersonale.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetaliiPersonale.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetaliiPersonale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetaliiPersonale.DisabledState.Parent = this.btnDetaliiPersonale;
            this.btnDetaliiPersonale.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnDetaliiPersonale.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetaliiPersonale.ForeColor = System.Drawing.Color.White;
            this.btnDetaliiPersonale.HoverState.Parent = this.btnDetaliiPersonale;
            this.btnDetaliiPersonale.Location = new System.Drawing.Point(0, 754);
            this.btnDetaliiPersonale.Name = "btnDetaliiPersonale";
            this.btnDetaliiPersonale.ShadowDecoration.Parent = this.btnDetaliiPersonale;
            this.btnDetaliiPersonale.Size = new System.Drawing.Size(239, 97);
            this.btnDetaliiPersonale.TabIndex = 8;
            this.btnDetaliiPersonale.Text = "Detalii Personale";
            this.btnDetaliiPersonale.Click += new System.EventHandler(this.btnDetaliiPersonale_Click);
            // 
            // elevMinimize
            // 
            this.elevMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.elevMinimize.Animated = true;
            this.elevMinimize.BackColor = System.Drawing.Color.Transparent;
            this.elevMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.elevMinimize.FillColor = System.Drawing.Color.Transparent;
            this.elevMinimize.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elevMinimize.HoverState.Parent = this.elevMinimize;
            this.elevMinimize.IconColor = System.Drawing.Color.White;
            this.elevMinimize.Location = new System.Drawing.Point(1308, 0);
            this.elevMinimize.Name = "elevMinimize";
            this.elevMinimize.PressedColor = System.Drawing.SystemColors.HotTrack;
            this.elevMinimize.ShadowDecoration.Parent = this.elevMinimize;
            this.elevMinimize.Size = new System.Drawing.Size(45, 29);
            this.elevMinimize.TabIndex = 16;
            // 
            // elevClose
            // 
            this.elevClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.elevClose.Animated = true;
            this.elevClose.BackColor = System.Drawing.Color.Transparent;
            this.elevClose.FillColor = System.Drawing.Color.Transparent;
            this.elevClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elevClose.HoverState.Parent = this.elevClose;
            this.elevClose.IconColor = System.Drawing.Color.White;
            this.elevClose.Location = new System.Drawing.Point(1353, 0);
            this.elevClose.Name = "elevClose";
            this.elevClose.PressedColor = System.Drawing.SystemColors.HotTrack;
            this.elevClose.ShadowDecoration.Parent = this.elevClose;
            this.elevClose.Size = new System.Drawing.Size(45, 29);
            this.elevClose.TabIndex = 15;
            this.elevClose.Click += new System.EventHandler(this.elevClose_Click);
            // 
            // FormElev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectHermes.Properties.Resources.wallpaper2;
            this.ClientSize = new System.Drawing.Size(1400, 850);
            this.ControlBox = false;
            this.Controls.Add(this.elevMinimize);
            this.Controls.Add(this.elevClose);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnDetaliiPersonale);
            this.Controls.Add(this.btnSituatieScolara);
            this.Controls.Add(this.btnAcademic);
            this.Controls.Add(this.btnSolicitareActe);
            this.Controls.Add(this.btnAvizier);
            this.Controls.Add(this.tabControlElev);
            this.Controls.Add(this.pictureBoxHeyStudent);
            this.Controls.Add(this.pictureBoxLogoElev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormElev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elev";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoElev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeyStudent)).EndInit();
            this.tabControlElev.ResumeLayout(false);
            this.homePage.ResumeLayout(false);
            this.homePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.avizier.ResumeLayout(false);
            this.avizier.PerformLayout();
            this.solicitareActe.ResumeLayout(false);
            this.solicitareActe.PerformLayout();
            this.academic.ResumeLayout(false);
            this.academic.PerformLayout();
            this.situatieScolara.ResumeLayout(false);
            this.situatieScolara.PerformLayout();
            this.contact.ResumeLayout(false);
            this.contact.PerformLayout();
            this.detaliiPersonale.ResumeLayout(false);
            this.detaliiPersonale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxLogoElev;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxHeyStudent;
        private Guna.UI2.WinForms.Guna2TabControl tabControlElev;
        private System.Windows.Forms.TabPage homePage;
        private System.Windows.Forms.TabPage avizier;
        private Guna.UI2.WinForms.Guna2TileButton btnAvizier;
        private Guna.UI2.WinForms.Guna2TileButton btnSolicitareActe;
        private Guna.UI2.WinForms.Guna2TileButton btnAcademic;
        private Guna.UI2.WinForms.Guna2TileButton btnSituatieScolara;
        private Guna.UI2.WinForms.Guna2TileButton btnContact;
        private Guna.UI2.WinForms.Guna2TileButton btnDetaliiPersonale;
        private Guna.UI2.WinForms.Guna2ControlBox elevMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox elevClose;
        private System.Windows.Forms.TabPage solicitareActe;
        private System.Windows.Forms.TabPage academic;
        private System.Windows.Forms.TabPage situatieScolara;
        private System.Windows.Forms.TabPage contact;
        private System.Windows.Forms.TabPage detaliiPersonale;
        private System.Windows.Forms.Label lblBuildInfo;
        private System.Windows.Forms.Label lblTiltluHomepage;
        private System.Windows.Forms.Label labelHomepage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblAvizierTitlu;
        private System.Windows.Forms.Label lblSolicitareTitlu;
        private System.Windows.Forms.Label lblAcademicTitlu;
        private System.Windows.Forms.Label lblSituatieScolaraTitlu;
        private System.Windows.Forms.Label lblContactTitlu;
        private System.Windows.Forms.Label lblDetaliiPersonaleTitlu;
    }
}