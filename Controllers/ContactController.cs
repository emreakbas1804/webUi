using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using webUi.Extensions;
using webUi.Models;
using static webUi.Program;
namespace webUi.Controllers
{

    public class ContactController : Controller
    {
        // private readonly TorServicesContext context;
        // public ContactController(TorServicesContext Context)
        // {
        //     context = Context;
        // }


        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(ContactModel model, string dil)
        {
            if (!ModelState.IsValid || !model.Kvkk)
            {
                if (dil == "tr")
                {
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Mesaj Gönderimi Başarısız",
                        Message = "Mesajınızı Bizimle Paylaşmak İçin Form Eksiksiz Doldurulmalı ve KVKK Onaylanmalı",
                        AlertType = "#a42121;"
                    });
                    return View();
                }
                if (dil == "en")
                {
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Message Send Failed",
                        Message = "In order to share your message with us, the form must be filled out completely.",
                        AlertType = "#a42121;"
                    });
                    return View();
                }
                if (dil == "es")
                {
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Envío de mensaje fallido",
                        Message = "Para compartir su mensaje con nosotros, el formulario debe ser llenado completamente.",
                        AlertType = "#a42121;"
                    });
                    return View();
                }
                if (dil == "it")
                {
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Invio messaggio non riuscito",
                        Message = "Per condividere il tuo messaggio con noi, il modulo deve essere compilato completamente.",
                        AlertType = "#a42121;"
                    });
                    return View();
                }

            }

            MailMessage MyMail = new MailMessage();
            MyMail.To.Add("info@torservicesturkey.net");
            MyMail.From = new MailAddress("webform@torservicesturkey.net");
            MyMail.Subject = "Tor-Services Turkey web sitesi İletişim Formu";
            MyMail.Body = $"<h2> İletişim Formuna Gelen Mesaj Detayı </h2> <hr> <br> <div> <p>Mail adresi : <b>{model.Mail}</b></p>  <p>Telefon Numarası : <b>{model.Phone}</b></p> <p>Mesajı : <b>{model.Message}</b></p></div>";
            MyMail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("webform@torservicesturkey.net", "Tor.Services!23");
            smtp.Port = 587;
            smtp.Host = "mail.kurumsaleposta.com";
            smtp.EnableSsl = false;
            try
            {
                smtp.Send(MyMail);
                if (dil == "tr")
                {
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Mesajınız İletildi",
                        Message = "Mesajınızı inceleyip en kısa sürede sizlere ulaşacağız",
                        AlertType = "#00923f;"
                    });
                    return View();
                }
                if (dil == "en")
                {
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Your Message Has Been Delivered",
                        Message = "We will review your message and contact you as soon as possible.",
                        AlertType = "#00923f;"
                    });
                    return View();
                }
                if (dil == "es")
                {
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Su mensaje ha sido entregado",
                        Message = "Revisaremos su mensaje y nos pondremos en contacto con usted lo antes posible.",
                        AlertType = "#00923f;"
                    });
                    return View();
                }
                if (dil == "it")
                {
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Il tuo messaggio è stato recapitato",
                        Message = "Esamineremo il tuo messaggio e ti contatteremo il prima possibile.",
                        AlertType = "#00923f;"
                    });
                    return View();
                }

            }

            catch (System.Exception ex)
            {

                TempData.Put("message", new AlertMessage()
                {
                    Title = "Error ! ",
                    Message = "Please try again later",
                    AlertType = "#00923f;"
                });
                Console.WriteLine(ex);
                return View();

            }



            return View();
        }

        [HttpGet]
        public IActionResult Offer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Offer(OfferModel model, string dil)
        {
            if (!model.KVKK)
            {
                if (dil == "tr")
                {
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Hata",
                        Message = "Mesajınızı Bizimle Paylaşmak İçin KVKK Onaylanmalı",
                        AlertType = "#a42121;"
                    });
                    return View();
                }
                if (dil == "en")
                {
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Error",
                        Message = "KVKK Must Be Approved To Share Your Message With Us",
                        AlertType = "#a42121;"
                    });
                    return View();
                }
                if (dil == "es")
                {
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Error",
                        Message = "KVKK debe estar aprobado para compartir su mensaje con nosotros",
                        AlertType = "#a42121;"
                    });
                    return View();
                }
                if (dil == "it")
                {
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Errore",
                        Message = "KVKK deve essere approvato per condividere il tuo messaggio con noi",
                        AlertType = "#a42121;"
                    });
                    return View();
                }

            }
            MailMessage MyMail = new MailMessage();
            MyMail.To.Add("info@torservicesturkey.net");
            MyMail.From = new MailAddress("webform@torservicesturkey.net");
            MyMail.Subject = "Tor-Services Turkey web sitesi İletişim Formu";
            MyMail.Body = $"<h2> Teklif Formuna Gelen Form Detayı </h2> <hr> <br> <div><p>Firma İsmi : <b>{model.CompanyName}</b></p>  <p>Firma Mail adresi : <b>{model.CompanyMail}</b></p>  <p>Firma Telefon Numarası : <b>{model.CompanyPhone}</b></p><p>Proje  İsmi : <b>{model.ProjectName}</b></p> <p>Proje detayı : <b>{model.ProjectDetails}</b></p>  <p>Beklentileri : <b>{model.RequestJob}</b></p></div>";
            MyMail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("webform@torservicesturkey.net  ", "Tor.Services!23");
            smtp.Port = 587;
            smtp.Host = "mail.kurumsaleposta.com";
            smtp.EnableSsl = false;
            try
            {
                smtp.Send(MyMail);
                if (dil == "tr")
                {
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Mesajınız İletildi",
                        Message = "Mesajınızı inceleyip en kısa sürede sizlere ulaşacağız",
                        AlertType = "#00923f;"
                    });
                    return View();
                }
                if (dil == "en")
                {
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Your Message Has Been Delivered",
                        Message = "We will review your message and contact you as soon as possible.",
                        AlertType = "#00923f;"
                    });
                    return View();
                }
                if (dil == "es")
                {
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Su mensaje ha sido entregado",
                        Message = "Revisaremos su mensaje y nos pondremos en contacto con usted lo antes posible.",
                        AlertType = "#00923f;"
                    });
                    return View();
                }
                if (dil == "it")
                {
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Il tuo messaggio è stato recapitato",
                        Message = "Esamineremo il tuo messaggio e ti contatteremo il prima possibile.",
                        AlertType = "#00923f;"
                    });
                    return View();
                }

            }

            catch (System.Exception)
            {

                TempData.Put("message", new AlertMessage()
                {
                    Title = "Error ! ",
                    Message = "Please try again later",
                    AlertType = "#00923f;"
                });
                return View();

            }

            return View();
        }


    }


}