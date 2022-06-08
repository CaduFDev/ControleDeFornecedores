/* PROC: Procurar Registro -PF */
exec VerRegistrosPF 1,1;

exec FiltrarPF 1, '2';

/* PROC: Procurar Registro -Pj */
exec VerRegistrosPJ 1,1;

exec FiltrarPJ 1, '2';


SELECT * FROM dbo.EMPRESA
select * from dbo.FORN_PF
select * from dbo.FORN_PJ
