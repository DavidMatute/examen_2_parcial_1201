namespace DavidMatuteExamen_2_Parcial_1201
{
    public class Clientes
    {
        
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Nomb_Medicamento { get; set; }
        public string Tipo_Medicamento { get; set; }
        public string Presentacion { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        //public int Subtotal { get; set; }
        //public double Descuento { get; set; }
        //public double Total_Pagar { get; set; }


        public Clientes() { }


        public Clientes(string _nombre, string _direccion, string _nomb_medicamento,
                        string _tipo_medicamento, string _presentacion,
                        int _cantidad, int _precio)
            //, int _subtotal,
            //            double _descuento,double _total_pagar)
        {
            Nombre = _nombre;
            Direccion = _direccion;
            Nomb_Medicamento = _nomb_medicamento;
            Tipo_Medicamento = _tipo_medicamento;
            Presentacion = _presentacion;
            Cantidad = _cantidad;
            Precio = _precio;
            //Subtotal = _subtotal;
            //Descuento = _descuento;
            //Total_Pagar = _total_pagar;
        }
    }
}