line0=Cesty BIND,11
chroot=Změnit (root) adresář pro běh BINDu na,3,výchozí
no_chroot=Je named.conf v chroot adresáři?,1,0-Ano,1-Ne
auto_chroot=Příkaz pro nalezení chroot adresáře,3,Použít výše uvedený pevný adresář
named_user=Uživatel&#44; který spustí BIND bude jako,3,výchozí
named_group=Skupina&#44; která spustí BIND bude jako,3,výchozí
zones_file=Přidat nové zóny do souboru,3,named.conf
relative_paths=Použít cestu k souboru soubor relativní zóny v <tt>named.conf</tt>?,1,1-Ano,0-Ne
line1=Možnosti zobrazení,11
show_list=Zobrazit domény jako,1,0-Ikony,1-Seznam
by_view=Kategorizovat při zobrazení zóny?,1,1-ano,0-ne
records_order=Seřadit zobrazené záznamy podle,1,1-jména,2-hodnoty,3-IP,0-přidání
max_zones=Maximální počet zobrazených zón,0
rev_def=Aktualizace reverse je,1,0-standardně zapnuta,1-standardně vypnuta,2-standardně se přepisuje
rev_must=Musí existovat reversní zóna?,1,1-ano,0-ne
support_aaaa=Podporuje DNS adresy IPv6?,1,1-ano,0-ne
allow_comments=Jsou povoleny komentáře u záznamů?,1,1-ano,0-ne
allow_wild=Jsou povoleny zástupné znaky?,1,1-ano,0-ne
allow_underscore=Povolit podtržení i jmen záznamů?,1,1-Ano,0-Ne
short_names=Konvertovat jména v záznamech do kanonické podoby?,1,0-ano,1-ne
extra_forward=Extra typy záznamů pro forward zóny,0
extra_reverse=Extra typy záznamů pro reverzní zóny,0
largezones=Zobrazit záznamy v zónách?,1,0-Ano,1-Ne (pro rozsáhlé zóny)
line2=Možnosti souboru se zónami,11
soa_style=Styl Serial number,1,0-běžící číslo,1-založeno na datumu (YYYYMMDDnn)
soa_start=Počáteční číslo v date-based SOA,0,3
master_ttl=Přidat $ttl na začátek nového souboru se zónami?,1,1-ano,0-ne
master_dir=Adresář pro master (hlavní) soubor zóny,3,výchozí
slave_dir=Adresář pro slave (podřízený) soubor zóny,3,výchozí
forwardzonefilename_format=Formát názvu forward (přesměrovaného) souboru zóny,0
reversezonefilename_format=Formát názvu reverse (reversního) souboru zóny,0
file_owner=Vlastník souborů zóny (user:group),3,výchozí
file_perms=Přístupová práva pro soubory zóny (octal),3,výchozí
default_prins=Výchozí master (hlavní) server pro hlavní zóny,0,Systémový hostname
default_master=Výchozí master (hlavní) server(y) pro slave (podřízené) zóny,0
updserial_on=Automaticky aktualizovat serial numbers?,1,1-ano,0-ne
ipv6_mode=Doména pro reverzní IPv6 adresy,1,1-ip6.arpa,0-ip6.int
confirm_zone=Potvrdit před smazáním zón?,1,1-Ano,0-Ne
confirm_rec=Potvrdit před smazáním záznamů?,1,1-Ano,0-Ne
free_nets=IP sítě pro volné adresy,3,Automatické
this_ip=Výchozí IP master (hlavního) serveru pro vzdálené slave zóny,3,IP adresa nebo hostname
line3=Konfigurace systému,11
named_conf=Plná cesta k souboru named.conf,0
named_path=Plná cesta ke spustitelnému souboru named,0
whois_cmd=Úplná cesto pro whois příkaz,0
ndc_cmd=Příkaz pro přepsání zóny,0
rndc_cmd=Úplná cesta k příkazu rndc,0
rndcconf_cmd=Úplná cesta k příkazu rndc-confgen,0
rndc_conf=Úplná cesta k souboru rndc.conf,0
pid_file=Výchozí jméno PID souboru,3,/var/run/named.pid
no_pid_chroot=PID soubor je v chroot adresáři?,1,0-Ano,1-Ne
start_cmd=Příkaz&#44; který spustí BIND,3,standardní
stop_cmd=Příkaz k zastavení BIND,3,Ukončující proces
restart_cmd=Příkaz aplikující konfiguraci BIND,3,Posílající HUP signál