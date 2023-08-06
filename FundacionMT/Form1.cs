namespace FundacionMT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void intervenciónTempranaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interv_Temprana mostrarInterv = new Interv_Temprana();
            mostrarInterv.Show();
        }

        private void inclusiónInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InclusionInicial mostrarInclusionIni = new InclusionInicial();
            mostrarInclusionIni.Show();
        }

        private void primeraInfanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrimeraInfancia mostrarPrimera = new PrimeraInfancia();
            mostrarPrimera.Show();
        }

        private void niñezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ninez mostrarNinez = new ninez();
            mostrarNinez.Show();
        }

        private void colegioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colegio mostrarcolegio = new colegio();
            mostrarcolegio.Show();
        }

        private void inclusiónEscolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InclusionEscolar mostrarIncluEscolar = new InclusionEscolar();
            mostrarIncluEscolar.Show();
        }

        private void vICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VICA mostrarVICA = new VICA();
            mostrarVICA.Show();
        }

        private void desarrolloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesarrolloEdadAdulta mostrarAdulta = new DesarrolloEdadAdulta();
            mostrarAdulta.Show();
        }

        private void intervenciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntervDistancia mostrarIntervDistancia= new IntervDistancia();
            mostrarIntervDistancia.Show(); 
        }

        private void anexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anexo mostrarAnexo= new Anexo();
            mostrarAnexo.Show();   
        }

        private void a7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atencion07 mostrarAten07=new Atencion07();
            mostrarAten07.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void a21ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atencion814 mostrarAten814=new Atencion814();
            mostrarAten814.Show();
        }

        private void a60ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atencion1560 mostrarAten1560 =new Atencion1560();
            mostrarAten1560.Show();
        }
    }
}