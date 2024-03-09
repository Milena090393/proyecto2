public class Program
{ 
    static void Main(string[] args) 
    {
    // Parcial Logica: PRIMER PUNTO
//se ddeclaran las variables que se utilizaran.


        double sueldobase, venta1, venta2, venta3, comisionprimermes, primercomision, segundacomision, terceracomision, totalmes, promediocomisiones;
        double objetivo = 1000000;
        //Primera pregunta: ¿Cuanto dinero obtendra por concepto de comisiones por las tres ventras que realiza en el mes?
        Console.WriteLine("Ingrese el valor de la primera venta");
        venta1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el valor de la segunda venta");
        venta2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el valor de la tercera venta");
        venta3 = Convert.ToDouble(Console.ReadLine());
        primercomision = venta1 * 0.1;
        segundacomision = venta2 * 0.1;
        terceracomision = venta3 * 0.1;
        comisionprimermes = (primercomision + segundacomision + terceracomision);
        Console.WriteLine("El dinero que obtendra el vendedor por concepto de comisiones es de " + comisionprimermes);

        // Segunda pregunta: ¿Cual es el total que recibira en el mes tomando en cuenta su sueldo base y comisiones?
        Console.WriteLine("Ingrese el valor del sueldo base");
        sueldobase = Convert.ToDouble(Console.ReadLine());
        totalmes = (sueldobase + comisionprimermes);
        Console.WriteLine("El total que recibira en el mes tomando en cuenta el sueldo base y las comisiones es de: " + totalmes);

        //Tercera pregunta: ¿Cual fue la venta que genero la mayor comision?
        if ((primercomision > segundacomision) && (segundacomision > terceracomision))

            Console.WriteLine("La mayor comision fue de la venta numero 1");

        else if ((segundacomision > primercomision) && (primercomision > terceracomision))
            Console.WriteLine("la mayor comision fue de la venta numero 2");
        else Console.WriteLine("la mayor comision fue de la tercera venta");

        //Cuarta pregunta: Cual fue el promedio de las comisiones que recibio por cada venta?
        promediocomisiones = (primercomision + segundacomision + terceracomision) / 3;
        Console.WriteLine("El promedio de las comisiones fue de: " + promediocomisiones);

        //Quinta pregunta: Beneficio extra
        if ((venta1 + venta2 + venta3) > objetivo)
            Console.WriteLine("Usted ha ganado un beneficio de $100.000");
        else Console.WriteLine("No tienes el valor minimo en ventas para obtener un beneficio");


    }


}
