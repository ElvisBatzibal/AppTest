using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppTest.ViewModel
{
    /// <summary>
    /// Login ViewModel
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {

        public string User { get; set; }
        public string Password { get; set; }

        #region Definition Command

        public ICommand LoginCommand => new RelayCommand(Login);
        private async void Login()
        {
            if (string.IsNullOrEmpty(this.User))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Por favor ingrese su correo.",
                    "Accept");
                return;
            }
            try
            {
                var Respuesta = new EmailAddressAttribute().IsValid(this.User);
                if (Respuesta == false)
                {
                    await Application.Current.MainPage.DisplayAlert(
                     "Error",
                     "Correo Invalido.",
                     "Accept");
                    return;
                }
            }
            catch (Exception)
            {
                await Application.Current.MainPage.DisplayAlert(
                   "Error",
                   "No es un correo valido.",
                   "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Por favor ingrese su contraseña en formato dia/mes/año.",
                    "Accept");
                return;
            }

            if (this.Password == DateTime.Now.ToString("dd/MM/yyyy"))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Success",
                    "Acceso Exitoso.",
                    "Accept");
                return;
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Contraseña Invalida.",
                    "Accept");
                return;
            }
        }
        #endregion

    }
}
