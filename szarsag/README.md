# Atestat
Info orara amit meg kell csinalni, lehessen kovetni hol tart stb xd

2025.02.02
megvannak: 
MainForm
- playButton, helpButton, exitButton, labelek
- a gombok elvisznek a megfelelo formokhoz (ChooseForm, HelpForm)
- nincs background design

HelpForm
- help.rtf meg nincs teljesen meg, csak proba, hogy mukodike 

ChooseForm
- 3 picturebox, random kepekkel - kellenek a rendes karakterek
- mousehover es mouseleave mukodik (megjelenik a leiras es a karakter neve - max designolni kell, hogy szebb legyen)
- back es continue gombok
- continue csak akkor jelenik meg ha ki van valasztva egy cucc
- CSAK EGY VALASZTAS

GameBoardForm
- menu gomb (reset, continue, game over)
- reset: ujrainditja az idot
- continue: a stoppolt idot folytassa
- game over: close()
- fel vannak tuntetve a pontok (timer tick), eletek prototipusa, coin szamolo
- van 3 picturebox (karakter, ground, obstacle)
- start buttonra elindult a timer, eltunik, megjelenik a tobbi cucc