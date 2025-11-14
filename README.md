# Yago Environment Builder

**Követelményspecifikáció**  
**Projekt neve:** Yago  
**Dátum:** 2025.11.03  
**Készítette:** Lénárt János, Ozibiusz Gergő, Köhler Gergő  

---

## Bevezetés

A **Yago Environment Builder** egy *Windows Forms* alapú asztali alkalmazás, amely a fejlesztők munkáját segíti azáltal, hogy automatizálja és leegyszerűsíti a különböző fejlesztői környezetek létrehozását.

A rendszer célja, hogy a felhasználók könnyedén összeállíthassák a kívánt környezetet különböző verziójú komponensekből (pl. PHP, Node.js, Composer), sablonokat készíthessenek, illetve új repository-kat generálhassanak a megadott beállítások alapján.

Az alkalmazás célcsoportja fejlesztők, akik gyakran dolgoznak több projekt párhuzamos kezelésével, és igénylik a gyors, automatizált környezetbeállítást.

A rendszer grafikus felülete három fő egységre tagolódik:
- **Versions modul**
- **Repository Creator modul**
- **Templates modul**

---

## Célok és funkciók

### 1. EntryPoint (Kezdőképernyő)
- Fő modulok közötti navigáció: `Versions`, `Repository Creator`, `Templates`  
- Logó és alapinformációk megjelenítése

### 2. Versions modul
- Fejlesztői környezet komponenseinek verzióválasztása (PHP, Node.js, Composer)
- Új konfiguráció mentése sablonként
- Mentett sablonok betöltése
- Környezet indítása a kiválasztott beállításokkal

### 3. Repository Creator modul
- Új projekt repository létrehozása
- Választható:
  - Alkalmazás típusa (pl. React, Laravel stb.)
  - Repository neve
  - Mentés helye
  - Verziók a Versions modulból
- Repository automatikus generálása a megadott paraméterek alapján

### 4. Templates modul
- Sablonok listázása (név, verziók)
- Sablon szerkesztése (PHP, Composer, Node)
- Új sablon mentése
- Sablon törlése

---

##  Érintettek és szerepkörök

### Alap felhasználó – Fejlesztő
A Yago alkalmazás fő használói:
- Környezetverziók kiválasztása és indítása  
- Sablonok létrehozása, szerkesztése, törlése  
- Új repository generálása  

---

##  Funkcionális követelmények

### 1. EntryPoint
- Induláskor megjelenik a kezdőképernyő a Yago logóval
- Navigáció a fő modulokhoz:
  - `Versions`
  - `Repository Creator`
  - `Templates`

### 2. Versions modul
- Verziók megadása: PHP, Composer, Node.js
- Sablon mentése és betöltése
- Környezet indítása a kiválasztott beállításokkal

### 3. Repository Creator modul
- Új repository létrehozása az alábbi paraméterekkel:
  - App típusa (React, Laravel, Angular stb.)
  - Projekt neve
  - Mentési hely
  - Verziók (Versions modulból)
- „**Create Repository**” gombbal automatikus létrehozás
- Érvényesség ellenőrzése (név, hely)

### 4. Templates modul
- Táblázatos nézet (név, verziók)
- Műveletek:
  - **Edit:** verziók szerkesztése  
  - **Delete:** sablon törlése  
- Adatok frissítése mentés után

---

##  Nem funkcionális követelmények
- Az alkalmazásnak gyorsan kell reagálnia a felhasználói műveletekre (pl. gombnyomások, sablon betöltés). 
- A rendszernek kezelnie kell az esetleges hibákat (pl. hibás elérési útvonal, hiányzó verzióinformáció).
- Az alkalmazás Windows Forms alapú, intuitív grafikus kezelőfelülettel.
- Az egyes funkciók (Versions, Repository Creator, Templates) jól elkülöníthető fülek formájában jelennek meg.
- A sablonadatok és beállítások helyben kerülnek tárolásra, nem kerülnek külső szerverre.
- Egységes vizuális megjelenés  
- Egyszerű navigáció
- Minden fő művelet után visszajelzés

---

##  Rendszerkörnyezet

| Tulajdonság | Érték |
|-------------|-------|
| Fejlesztési nyelv | C# |
| IDE | Visual Studio 2022 |
| .NET verzió | .NET 8.0 vagy magasabb |
| Projekt típusa | Windows Forms Application |
| Verziókezelés | Git |

### Adatkezelés
- Sablonadatok a **Templates.txt** fájlban tárolódnak  
- Formátum: `név;php;composer;node`  
- Példa:
  ```txt
  Moodle;8.2;2.6;18.0


- Név: A sablon neve (pl. Moodle, Neptun, Wordpress)  
- php: A kiválasztott PHP verzió  
- composer: A Composer verziója (ha nincs megadva, akkor „default” érték kerül be)  
- node: A Node.js verziója  

A fájl a program gyökérkönyvtárában található, és az alkalmazás betöltéskor automatikusan beolvassa a sablonokat, illetve mentéskor frissíti azokat.  

---

##  7. Korlátozások
- Az alkalmazás kizárólag **Windows operációs rendszeren** futtatható.  
- A működéshez szükséges a **.NET Runtime 8.0** vagy újabb telepítése.  
- Az alkalmazás nem tartalmaz automatikus verziófrissítési funkciót, a frissítéseket manuálisan kell elvégezni.  
- Az alkalmazás nem többfelhasználós, egyszerre egy személy használhatja ugyanazon a gépen.  

---

##  8. Példa felhasználói történetek

- Mint fejlesztő, szeretném kiválasztani a PHP, Node.js és Composer verziókat, hogy az adott projekt környezetét pontosan beállíthassam.  
- Mint fejlesztő, szeretném elmenteni a kiválasztott verziókat sablonként, hogy később újra felhasználhassam azokat.  
- Mint fejlesztő, szeretném elindítani a fejlesztői környezetet a kiválasztott verziókkal, hogy azonnal dolgozni tudjak a projekten.  
- Mint fejlesztő, szeretném megadni az alkalmazás típusát, a projekt nevét, a mentés helyét és a verziókat, hogy új repository-t generálhassak a kívánt környezetben.  
- Mint fejlesztő, szeretném szerkeszteni a kiválasztott sablon verzióit (PHP, Composer, Node), hogy a sablon mindig naprakész legyen.  
- Mint felhasználó, szeretném törölni a nem szükséges sablonokat.  
- Mint felhasználó, szeretném, ha az alkalmazás visszajelzést adna a sikeres vagy sikertelen műveletekről (pl. sablon mentés, repository létrehozás), hogy biztos legyek a műveletek eredményében.  

---

##  9. Elfogadási kritériumok

- A felhasználó a kezdőképernyőről el tud navigálni a Versions, Repository Creator és Templates modulokra.  
- A felhasználó kiválaszthatja a PHP, Composer és Node.js verziókat.  
- A felhasználó elmentheti a kiválasztott verziókat sablonként.  
- A felhasználó betöltheti a korábban mentett sablonokat.  
- A felhasználó elindíthatja a fejlesztői környezetet a kiválasztott verziókkal.  
- A felhasználó létre tud hozni új repository-t a megadott paraméterekkel.  
- A rendszer ellenőrzi a repository név és mentési hely érvényességét.  
- A felhasználó sablonokat tud szerkeszteni és törölni.  
- Minden fő művelet (mentés, törlés, létrehozás, indítás) után visszajelzés jelenik meg.  

---

##  10. Jövőbeli bővítési lehetőségek

- A rendszer Windows mellett **macOS** és **Linux** operációs rendszeren is futtathatóvá tétele.  
- A komponensek (PHP, Node.js, Composer) automatikus frissítése a legújabb stabil verziókra.  
- Több fejlesztő használhatja ugyanazt a gépet külön bejelentkezéssel, saját sablonokkal és beállításokkal.  
- A sablonok és repository beállítások **felhőben történő tárolása**, hogy könnyen szinkronizálhatók legyenek több gép között.  
- A létrehozott környezetekhez előre beállított **build- és teszt-scriptek** futtatása.  

---

