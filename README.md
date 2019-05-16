# bplatvanyossagok
Budapest egy fontos turisztikai központ. Fontos kérdés egy turista szempontjából, hogy mit és milyen sorrendben nézzen meg a városban és oda hogy jusson el, sétáljon, béreljen egy kocsit vagy BKV-t használjon. A program működése legyen független a konkrét tartalmaktól, bármilyen ILátványosság interfészt megvalósító osztályt tudjon kezelni, ami a következő tuljadonságokat írja elő:
- int JegyÁr, ÉrdekességiSzint érdekesség (pl. Unalmas, Átlagos, EgészJó, NagyonJó)
- Írjon elő egy ILátványosság[] HasonlóLátványosságok() metódust
Készítsen el egy TuristaLátványosság osztályt, amely megvalósítja az ILátványosság interfészt (azonban nem adunk megvalósítást). Az osztály minden példánya tartalmazzon egy ILátványosság elemeket tartalmazó többszörösen (oda-vissza referencia) láncolt listát, ami az adott látványossághoz hasonló látványosságokat tartalmazza érdekesség szerint rendezve.
Készítsen el néhány osztályt (ehhez építsen ki egy célszerű osztályhierarchiát), amelyek örökölnek a TuristaLátványosság osztályból, és ezekből hozzon létre mintapéldányokat:
- Pl. Múzeum, Piac, Fürdő -> TermálFürdő
Ezeket a látványosságokat (ILátványosságok) tárolja el egy irányított gráfban (csúcsok), földrajzi elhelyezkedésnek megfelelően (élek = milyen messze helyezkednek el egymástól).
- Legyen lehetőség elemek hozzáadására, és törlésére a gráfból.
- A NagyonJó érdekességű látványosságokat tárolja el egy külön láncolt listában is
- Készítsen egy void ÉleketFrissít(SzempontDelegált delegáltpéldány); metódust, mely mindent élt frissít a következőek szerint: SzempontDelegált => float (Csúcs,Csúcs); Pl.: A -> B él frissítése: az A - > B értéke a B érdekességének arányában csökkenjen. Sok más szempont elképzelhető, lényeg, hogy saját delegálton keresztül legyen megvalósítva
- A felhasználó megadhasson egy kiindulási és egy célpontot és közbülső pontokat és azok alapján állítson össze egy utat, amely optimális. A visszatérési érték egy gráf legyen. Dobjon egy kivételt, ha nem lehetséges ilyen összefüggő utat definiálni.
Hozzon
- Adja meg, hogy milyen kiinduló pontból (ILátványosság), milyen végpontba, milyen állomásokon
létre egy gráfot látványosságokból. Készítsen egy Turista osztályt, ahol
keresztül jutna el (a köztes állomások közötti sorrendet az algoritmus határozza meg).
- Tesztelje a gráf úttervező metódusát. Próbálja ki, hogy a kiválaszott érintendő ILátványosságokhoz hasonló látványosságot hozzá lehet-e adni a tervezett úthoz.
A feladat megoldása során tartsa be a tanult OOP alapelveket (egységbezárás, láthatóságok, öröklés), kivételkezelés segítségével kezelje a felmerülő problémás eseteket. Ahol szükséges, egészítse ki a megadott osztályhierarchiát, illetve használja a tanult technikákat (eseménykezelés, generikus típusok, operátor overloading stb.).
