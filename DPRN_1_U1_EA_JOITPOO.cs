using System;//Microsoft Docs Error CS0246, The following example causes CS0246 because an object of type Type was used where an actual type was expected.
public class DatosPacientes{//Definición de la clase que almacena los datos de los pacientes
   public DatosPacientes()//Declaracion del constructor de la clase DatosPacientes
    {
        this.nombre = nombre;//Sobrecarga al constructor
        this.apPaterno = apPaterno;//Sobrecarga al constructor
        this.apMaterno = apMaterno;//Sobrecarga al constructor
        this.edad = edad;//Sobrecarga al constructor
        this.Sexo = Sexo;//Sobrecarga al constructor
        this.eCivil = eCivil;//Sobrecarga al constructor
        this.discapacidad = discapacidad;//Sobrecarga al constructor
        this.eMail = eMail;//Sobrecarga al constructor
        this.fNacimiento = fNacimiento;//Sobrecarga al constructor

    }
    public String nombre { get; set; }//Declarando el atributo nombre, que tiene la clase DatosPacientes
    public String apPaterno { get; set; }//Declarando el atributo apPaterno, que tiene la clase DatosPacientes
    public String apMaterno { get; set; }//Declarando el atributo apMaterno, que tiene la clase DatosPacientes
    public Int32 edad { get; set; }//Declarando el atributo edad, que tiene la clase DatosPacientes
    public String Sexo { get; set; }//Declarando el atributo Sexo, que tiene la clase DatosPacientes
    public String eCivil { get; set; }//Declarando el atributo eCivil, que tiene la clase DatosPacientes
    public String discapacidad { get; set; }//Declarando el atributo dicapacidad, que tiene la clase DatosPacientes
    public String eMail { get; set; }//Declarando el atributo eMail, que tiene la clase DatosPacientes
    public String fNacimiento { get; set; }//Declarando el atributo fecha de nacimiento, que tiene la clase DatosPacientes
    
}
public class CalcularPrecio{//Declaración de la clase que realizará los calculos
    public double ingrMensual{get; set;}//Declaración del atributo del tipo doble y llamado ingreso mensual, posee la información del ingreso mensual capturado por el usuario
    public double calcularPrecio(double p){//Metodo para calcular el precio de la vacuna, de tipo doble y llamado calcularPrecio
        return (ingrMensual*0.015);//Regresará el total despues de realizar la operacion de sacarle el 1.5% del total del ingreso mensual ganado por el trabajador
    }
    public double calcularPrecio(){//Sobrecargamos el constructor
        return (this.ingrMensual*0.015);

    }
}
