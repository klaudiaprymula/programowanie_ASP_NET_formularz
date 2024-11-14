using System.ComponentModel.DataAnnotations;

namespace Formularz.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Imię jest wymagane.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Imię musi mieć minimum 2 znaki.")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Nazwisko musi mieć minimum 2 znaki.")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Adres e-mail jest wymagany.")]
        [EmailAddress(ErrorMessage = "Wprowadź poprawny adres e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Hasło musi mieć minimum 8 znaków.")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).+$",
            ErrorMessage = "Hasło musi zawierać co najmniej jedną cyfrę, jedną dużą i jedną małą literę.")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Potwierdzenie hasła jest wymagane.")]
        [Compare("Haslo", ErrorMessage = "Hasła muszą być takie same.")]
        public string PotwierdzenieHasla { get; set; }

        [Phone(ErrorMessage = "Wprowadź poprawny numer telefonu.")]
        public string NrTelefonu { get; set; }

        [Required(ErrorMessage = "Wiek jest wymagany.")]
        [Range(10, 80, ErrorMessage = "Wiek musi być w przedziale od 10 do 80 lat.")]
        public int Wiek { get; set; }

        [Required(ErrorMessage = "Miasto jest wymagane.")]
        public string Miasto { get; set; }
    }
}
