using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Exception.Helpers.Extections
{
    public static class UseExtension
    {
        public static void ValidateEmail(this string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                    throw new ExceptionEmail("Email boş ola bilməz.");

                // 1 @ işarəsi olub-olmadığını yoxlayırıq
                int atCount = 0;
                foreach (char c in email)
                {
                    if (c == '@')
                        atCount++;
                }
                if (atCount != 1)
                    throw new ExceptionEmail("Email yalnız 1 dene '@' işarəsi içermElidir.");

                // Boşluq olub-olmadığını yoxlayırıq
                if (email.Contains(' '))
                    throw new ExceptionEmail("Email boşluq içermEmElidir.");

                // Sonu .com, .az, .org ilə bitib-bitmədiyini yoxlayırıq
                if (!(email.EndsWith(".com") || email.EndsWith(".az") || email.EndsWith(".org")))
                    throw new ExceptionEmail("Email yalnız .com, .az və ya .org ilə bitE bilEr.");

                Console.WriteLine("Email düzgün formatdadır.");
            }
            catch (ExceptionEmail ex)
            {
                Console.WriteLine($"Email xEtası: {ex.Message}");
            }
        }
    }
}
