Console.Title = "TF2 Español";
Console.BackgroundColor = ConsoleColor.Black;

Console.SetWindowSize(60, 5);
Console.SetBufferSize(60, 5);

var ruta = string.Empty;
if (Environment.Is64BitOperatingSystem)
    ruta = "C:/Program Files (x86)/Steam/steamapps/common/Team Fortress 2/tf/resource/";
else
    ruta = "C:/Program Files/Steam/steamapps/common/Team Fortress 2/tf/resource/";

var inglés = "tf_english.txt";
var español = "tf_spanish.txt";
var rutaProvisoria = "temp.txt";

// Cambia de nombre archivos
File.Move(ruta + inglés, ruta + rutaProvisoria);
File.Move(ruta + español, ruta + inglés);
File.Move(ruta + rutaProvisoria, ruta + español);

Console.WriteLine("Intercambiado textos español/inglés correctamente");
Console.ReadKey();