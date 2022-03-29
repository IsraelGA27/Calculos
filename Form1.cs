namespace Calculos
{
    public partial class Form1 : Form
    {
        private Label? lblFigura;
        private ComboBox? cmbFiguras;
        private Label? lblCalculo;
        private ComboBox? cmbCalculos;
        private Label? lblAltura;
        private TextBox? txtAltura;

        private Label? lblMensaje;
        private Label? lblMensaje2;

        private TextBox? txtLadoUno;
        private Label? lblLadoUno;

        private TextBox? txtLadoDos;
        private Label? lblLadoDos;

        private Label? lblBase;
        private TextBox? txtBase;

        private Label? lblResultado;
        private TextBox? txtResultado;
        private Button? btnCalcular;
        public Form1()
        {
            InitializeComponent();
            IInicializarComponentes();
        }

        private void IInicializarComponentes()
        {
            // Tamaño de la ventana
            this.Size = new Size(300, 350);

            //Etiqueta Figura
            lblFigura = new Label();
            lblFigura.Text = "Figura";
            lblFigura.AutoSize = true;
            lblFigura.Location = new Point(10, 10);

            //Etiqueta Mensaje
            lblMensaje = new Label();
            lblMensaje.Text = "Para REINICIAR";
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(10, 190);

            lblMensaje2 = new Label();
            lblMensaje2.Text = "seleccionar(FIGURA/CALCULO)";
            lblMensaje2.AutoSize = true;
            lblMensaje2.Location = new Point(10, 210);

            //ComboBox Figuras
            cmbFiguras = new ComboBox();
            cmbFiguras.Items.Add("Selecciona figura");
            cmbFiguras.Items.Add("Cuadrado");
            cmbFiguras.Items.Add("Triangulo");
            cmbFiguras.Items.Add("Rectangulo");
            cmbFiguras.SelectedIndex = 0;
            cmbFiguras.Location = new Point(10, 40);
            cmbFiguras.SelectedValueChanged += new EventHandler(Form1_Load);

            //Etiqueta Calculo
            lblCalculo = new Label();
            lblCalculo.Text = "Cálculo";
            lblCalculo.AutoSize = true;
            lblCalculo.Location = new Point(150, 10);

            //ComboBox Calculos
            cmbCalculos = new ComboBox();
            cmbCalculos.Items.Add("Selecciona calculo");
            cmbCalculos.Items.Add("Périmetro");
            cmbCalculos.Items.Add("Área");
            cmbCalculos.SelectedIndex = 0;
            cmbCalculos.Location = new Point(150, 40);
            cmbCalculos.SelectedValueChanged += new EventHandler(Form1_Load);

            //Etiqueta Altura
            lblAltura = new Label();
            lblAltura.Text = "Altura";
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(10, 80);
            lblAltura.Visible = false;

            //TextBox Altura
            txtAltura = new TextBox();
            txtAltura.Size = new Size(100, 20);
            txtAltura.Location = new Point(60, 75);
            txtAltura.Visible = false;

            //Etiqueta RESULTADO
            lblResultado = new Label();
            lblResultado.Text = "Resultado";
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(10, 270);

            //TextBox Prueba
            txtResultado = new TextBox();
            txtResultado.Size = new Size(100, 20);
            txtResultado.Location = new Point(90, 270);

            // Cosas del triangulo

           // Etiqueta lado 1
            lblLadoUno = new Label();
            lblLadoUno.Text = "Lado Uno";
            lblLadoUno.AutoSize = true;
            lblLadoUno.Location = new Point(10, 80);
            lblLadoUno.Visible = false;

            txtLadoUno = new TextBox();
            txtLadoUno.Size = new Size(100, 20);
            txtLadoUno.Location = new Point(90, 80);
            txtLadoUno.Visible=false;

            // Lado 2
            lblLadoDos = new Label();
            lblLadoDos.Text = "Lado Dos";
            lblLadoDos.AutoSize = true;
            lblLadoDos.Location = new Point(10, 120);
            lblLadoDos.Visible = false;

            txtLadoDos = new TextBox();
            txtLadoDos.Size = new Size(100, 20);
            txtLadoDos.Location = new Point(90, 120);
            txtLadoDos.Visible = false;

            //Etiqueta Base
            lblBase = new Label();
            lblBase.Text = "Base";
            lblBase.AutoSize = true;
            lblBase.Location = new Point(10, 160);
            lblBase.Visible = false;

            //TextBox base
            txtBase = new TextBox();
            txtBase.Size = new Size(100, 20);
            txtBase.Location = new Point(60, 160);
            txtBase.Visible = false;


            


            //Boton Calcular
            btnCalcular = new Button();
            btnCalcular.Text = "Calcular";
            btnCalcular.AutoSize = true;
            btnCalcular.Location = new Point(210, 230);
            btnCalcular.Click += new EventHandler(btnCalcular_Click);

            //Agregar controles a la ventana
            this.Controls.Add(lblFigura);
            this.Controls.Add(cmbFiguras);
            this.Controls.Add(lblCalculo);
            this.Controls.Add(cmbCalculos);
            this.Controls.Add(lblAltura);
            this.Controls.Add(txtAltura);

            this.Controls.Add(lblMensaje);
            this.Controls.Add(lblMensaje2);

            this.Controls.Add(lblLadoUno);
            this.Controls.Add(txtLadoUno);

            this.Controls.Add(lblLadoDos);
            this.Controls.Add(txtLadoDos);

            this.Controls.Add(lblBase);
            this.Controls.Add(txtBase);

            this.Controls.Add(lblResultado);
            this.Controls.Add(txtResultado);
            this.Controls.Add(btnCalcular);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cmbCalculos.SelectedIndex != 0 && cmbFiguras.SelectedIndex != 0)
            {
                if (cmbFiguras.SelectedItem.ToString() == "Cuadrado")
                {
                    //cmbFigura.SelectedIndex==1
                    if (cmbCalculos.SelectedItem.ToString() == "Périmetro")
                    {
                        txtAltura.Visible = true;
                        lblAltura.Visible = true;
                    }
                    if (cmbCalculos.SelectedItem.ToString() == "Área")
                    {
                        txtAltura.Visible = true;
                        lblAltura.Visible = true;
                    }
                }
                if (cmbFiguras.SelectedItem.ToString() == "Triangulo")
                {
                    if (cmbCalculos.SelectedItem.ToString() == "Périmetro")
                    {
                        
                        txtLadoUno.Visible = true;
                        lblLadoUno.Visible = true;

                        txtLadoDos.Visible = true;
                        lblLadoDos.Visible = true;

                        txtBase.Visible = true;
                        lblBase.Visible = true;

                    }
                    if (cmbCalculos.SelectedItem.ToString() == "Área")
                    {
                        txtAltura.Visible = true;
                        lblAltura.Visible = true;
                        lblBase.Visible = true;
                        txtBase.Visible = true;
                    }
                }
                if (cmbFiguras.SelectedItem.ToString() == "Rectangulo")
                {
                    if (cmbCalculos.SelectedItem.ToString() == "Périmetro")
                    {

                        txtBase.Visible = true;
                        lblBase.Visible = true;

                        txtAltura.Visible = true;
                        lblAltura.Visible = true;

                    }
                    if (cmbCalculos.SelectedItem.ToString() == "Área")
                    {
                        txtAltura.Visible = true;
                        lblAltura.Visible = true;
                        lblBase.Visible = true;
                        txtBase.Visible = true;
                    }
                }
            }
            else
            {
                txtAltura.Visible = false;
                lblAltura.Visible = false;

                txtLadoUno.Visible = false;
                lblLadoUno.Visible = false;

                txtLadoDos.Visible = false;
                lblLadoDos.Visible = false;

                lblBase.Visible = false;
                txtBase.Visible = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            string calculo = cmbCalculos.SelectedItem.ToString();

            string Tria = cmbFiguras.SelectedItem.ToString();

            if (Tria == "Rectangulo")
            {
                if(calculo == "Périmetro")
                {
                    int dos = 2;
                    int altura1 = Convert.ToInt32(txtAltura.Text);
                    int b = Convert.ToInt32(txtBase.Text);
                    txtResultado.Text =  (dos * (b + altura1)).ToString();
                }
                if (calculo == "Área")
                {
                    int altura = Convert.ToInt32(txtAltura.Text);
                    int b = Convert.ToInt32(txtBase.Text);
                    txtResultado.Text = (b * altura).ToString();
                }
            }

            if (Tria == "Cuadrado")
            {
                if (calculo == "Périmetro")
                {
                    int altura = Convert.ToInt32(txtAltura.Text);
                    txtResultado.Text = (altura * 4).ToString();
                }
                if (calculo == "Área")
                {
                    int altura = Convert.ToInt32(txtAltura.Text);
                    txtResultado.Text = (altura * altura).ToString();
                }
            }

            if(Tria == "Triangulo")
            {
                if (calculo == "Périmetro")
                {
                    int lado1 = Convert.ToInt32(txtLadoUno.Text);
                    int lado2 = Convert.ToInt32(txtLadoDos.Text);
                    int b1 = Convert.ToInt32(txtBase.Text);
                    txtResultado.Text = (b1 + lado1 + lado2).ToString();

                }
                if (calculo == "Área")
                {
                    int b = Convert.ToInt32(txtBase.Text);
                    int altura2 = Convert.ToInt32(txtAltura.Text);
                    float total = b * altura2;
                    txtResultado.Text = (total/2).ToString();
                }
            }

        }
    }
}