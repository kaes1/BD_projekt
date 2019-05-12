Bazy Danych - Projekt
Informatyka SSI
Semestr 6
Rok Akademicki 2018/2019

Sk³ad sekcji:
Natalia Badora
Aleksandra Dyrda
Micha³ Kafka
Kamil Polok
Krzysztof Sobocik

RA2
System obs³ugi rezerwacji wizyt lekarskich.


Przygotowanie aplikacji do pracy:
- Do uruchomienia aplikacji wymagany jest .Net Framework w wersji 4.0 lub wy¿szej.
- Do korzystania z aplikacji konieczne jest utworzenie bazy danych MS SQL Server uruchamiaj¹c wybrany skrypt z folderu "Database".
- Zawartoœæ folderu "Deployment" nale¿y skopiowaæ do dogodnej lokalizacji.
- W skopiowanym pliku "ClinicApp.exe.config" nale¿y zmieniæ connectionString na w³aœciwy dla nowo utworzonej bazy danych Clinic.
- Aplikacjê nale¿y uruchamiaæ poprzez "ClinicApp.exe".
- Niepoprawne skonfigurowanie po³¹czenia z baz¹ danych spowoduje zatrzymanie pracy aplikacji przy próbie logowania.


Loginy i has³a do wszystkich ról (ROLA:LOGIN:HAS£O):
Admin:admin:admin
Receptionist:receptionist:recep
Doctor:doctor:doctor
LabTechnician:labtechnician:labtec
LabManager:labmanager:labman


Repozytorium Github:
https://github.com/kaes1/BD_projekt