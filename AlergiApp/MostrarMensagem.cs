﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AlergiApp
{
    public class MostrarMensagem
    {
        //Declara o metódo que coloca um Toast 
        public static void Mostrar(string mensagem)
        {
            MessagingCenter.Send(mensagem, "Mensagem");
        }
    }
}
