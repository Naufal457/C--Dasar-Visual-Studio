using System;
//    step ke 1
//    referensi folder
//    nama project + nama folder + nama sub foder
using Console261._02_Latihan;
using Console261._01_Materi;

namespace Console261 // nama project
{
    class Program // nama class
    {
        static void Main(string[] args)
        {
            // step ke 2 - Declarasi object
            // membuat object dari class
            // nama_class nama_variable = new nama_class()
         
            _001_Exercise exercise = new _001_Exercise();
            _002_Exercise exerciseloop = new _002_Exercise();

            _001_Syntax syntax = new _001_Syntax();
            _002_Comments comments = new _002_Comments();
            _003_WriteAndWriteLine Write = new _003_WriteAndWriteLine();
            _004_Variabel variables = new _004_Variabel();
            _005_DataType datatype = new _005_DataType();
            _006_Casting casting = new _006_Casting();
            _007_UserInput userinput = new _007_UserInput();
          

            // step ke 3 - panggil method dari object yg dibuat
            // cara panggil
            // variable_object.nama_method();
            
            //datatype.dataTypes();
            exerciseloop.exerciseLooping();

            Console.ReadKey();

        }


    }


}
// dotnet restore
// dotnet build
