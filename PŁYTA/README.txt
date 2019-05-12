Bazy Danych - Projekt
Informatyka SSI
Semestr 6
Rok Akademicki 2018/2019

Sk�ad sekcji:
Natalia Badora
Aleksandra Dyrda
Micha� Kafka
Kamil Polok
Krzysztof Sobocik

RA2
System obs�ugi rezerwacji wizyt lekarskich.


Przygotowanie aplikacji do pracy:
- Do uruchomienia aplikacji wymagany jest .Net Framework w wersji 4.0 lub wy�szej.
- Do korzystania z aplikacji konieczne jest utworzenie bazy danych MS SQL Server uruchamiaj�c wybrany skrypt z folderu "Database".
- Zawarto�� folderu "Deployment" nale�y skopiowa� do dogodnej lokalizacji.
- W skopiowanym pliku "ClinicApp.exe.config" nale�y zmieni� connectionString na w�a�ciwy dla nowo utworzonej bazy danych Clinic.
- Aplikacj� nale�y uruchamia� poprzez "ClinicApp.exe".
- Niepoprawne skonfigurowanie po��czenia z baz� danych spowoduje zatrzymanie pracy aplikacji przy pr�bie logowania.


Loginy i has�a do wszystkich r�l (ROLA:LOGIN:HAS�O):
Admin:admin:admin
Receptionist:receptionist:recep
Doctor:doctor:doctor
LabTechnician:labtechnician:labtec
LabManager:labmanager:labman


Repozytorium Github:
https://github.com/kaes1/BD_projekt