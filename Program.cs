using System;
DatosPacientes pacientes = new DatosPacientes();//Creacion del objeto llamado pacientes del tipo de la clase DatosPacientes
CalcularPrecio precios = new CalcularPrecio();//Creacion del objeto llamado precios del tipo de la clase CalcularPrecio 
Console.WriteLine("Hola, Bienvenida/o al registro en sistema COVID-19MX");
Console.WriteLine("Favor de Capturar su nombre: ");
pacientes.nombre = Console.ReadLine();
String subNombre = pacientes.nombre.Substring(0,1);//Substring para sacar la primera letra del nombre
Console.WriteLine("Favor de Capturar su Apellido Paterno");
pacientes.apPaterno = Console.ReadLine();
String subApellidopaterno = pacientes.apPaterno.Substring(1,1);//Substring para sacar la segunda letra del apellido Paterno
Console.WriteLine("Favor de Capturar su Apellido Materno: ");
pacientes.apMaterno = Console.ReadLine();
String subApellidomaterno = pacientes.apMaterno.Substring(2,1);//Substring para sacar la tercera letra del apellido materno
Random rnd = new Random();//Creamos un nuevo metodo random y se lo asignamos a la variable rnd
int numRandom = rnd.Next(0,1000);//Inicializamos la variable que contiene el metodo random y lo inicialiamos con Next desde o hasta 1000, así generará 1000 nuemeros aleatorios
Random rnd1 = new Random();//Creamos un nuevo metodo random y se lo asignamos a la variable rnd1
String [] randomdLetras ={"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};//Asignamos el metodo random a un arreglo que contiene todas las letras del abecedario.
int lIndex =rnd1.Next(randomdLetras.Length);//Asignamos a la variable lIndex e inicializamos el metodo random con Next asignado a la variable randomLetras que contiene todas las letras a elegir
Console.WriteLine("Favor de capturar su genero M para Masculino o F para Femenino");
pacientes.Sexo = Console.ReadLine();
Console.WriteLine("Favor de capturar su fecha de nacimiento AAAA/MM/DD: ");
DateTime fNacimiento = DateTime.Parse(Console.ReadLine());//Creamos una variable y se la asignamos al metodo DateTime para capturar el formato y la fecha de nacimiento del paciente
DateTime fechaActual = DateTime.Today;//Creamos una variable de tipo DateTime y le asignamos la fecha actual
TimeSpan edad= fechaActual-fNacimiento;//En un metodo Timespan asignamos una variable que nos servirá para realizar el calculo de la edad del paciente
edad=edad/365;//Tenemos que dividir entre 365 el valor de la edad puesto que esta tiene un valor de dias
Console.WriteLine("Capture Estado Civil: ");
pacientes.eCivil = Console.ReadLine();
Console.WriteLine("Capture si posee alguna discapacidad, mencione de que tipo: ");
pacientes.discapacidad=Console.ReadLine();
Console.WriteLine("Capture su ingreso mensual: ");
precios.ingrMensual = double.Parse(Console.ReadLine());
Console.WriteLine("Capture su correo electronico: ");
pacientes.eMail = Console.ReadLine();
Console.WriteLine("Capturar la fecha de Aplicación de la vacuna AAAA/MM/DD: ");
System.DateTime fAplicacion = DateTime.Parse(Console.ReadLine());
System.DateTime caducidad = DateTime.Now.AddDays(180);//Considerando que la hora de aplicacion se acaba de dar se considera comenzar a contar a partir del dia de hoy y hasta un total de 180 dias 
Console.WriteLine("Favor de capturar la hora de la aplicacion de la vacuna HH:MM:SS: ");
System.DateTime hAplicacion = System.DateTime.Parse(Console.ReadLine());//Del tipo dateTime se lee la hora en la que se aplicó la vacuna
System.TimeSpan duracion = new System.TimeSpan(0, 5, 0, 0);//Se crea un nuevo objeto de tipo TimeSpan y en el se asigna un variable que contará solo las horas
System.DateTime cumpleH = hAplicacion.Add(duracion);//Se le asigna a la variable cumpleH el valor que tiene la variable hAplicacion y que capturó el usuario y se le suman las horas
//Impresión de la información en pantalla//
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
Console.WriteLine("Los datos registrados son los siguientes: ");
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
Console.WriteLine("Nombre completo del paciente: " + pacientes.nombre + " " + pacientes.apPaterno + " " + pacientes.apMaterno);
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
Console.WriteLine("La edad del paciente es de: " + edad.Days + " Años ");
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
Console.WriteLine("El genero del paciente es: " + pacientes.Sexo);
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
Console.WriteLine("El estado civil del paciente es: " + pacientes.eCivil);
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
Console.WriteLine("El paciente padece alguna discapacidad?: " + pacientes.discapacidad);
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
Console.WriteLine("El costo de la vacuna para el paciente es de:$" + precios.calcularPrecio());
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
Console.WriteLine("El correo electrónico del paciente es: " +pacientes.eMail);
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
Console.WriteLine("El paciente " + pacientes.nombre + " " + "no Podrá realizar ejercicios en las proximas 5 horas, estas se cumpliran hasta las: " + "{0:hh:mm:ss}", cumpleH );
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
Console.WriteLine("Considerando que la vacuna se acaba de aplicar la vigencia de esta será hasta el dia y hora siguiente: " + caducidad);
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
Console.WriteLine("El folio generado es: " + subNombre + subApellidopaterno + subApellidomaterno + numRandom + randomdLetras[lIndex]);//Generación del folio concatenando los resultados
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

