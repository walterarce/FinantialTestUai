# FinantialTestUai

Dado un escenario de una entidad financiera nos manifiestan la necesidad de desarrollar un sistema
para administrar las tarjetas de crédito que posee.
Nos manifiestan que poseen tres tipos de tarjetas: Platinum, Gold y Plata
Los tres tipos de tarjeta manejan movimientos en pesos y dólares.
Para la entidad financiera sus clientes son los titulares de las tarjetas.
Una tarjeta posee un titular y estos pueden tener más de una tarjeta.
Las tarjetas y los titulares se crean por separado y debe existir un botón asignar para relacionar
un titular con una tarjeta y otro botón para quitar la asignación que solo debe ser posible accionar
si la tarjeta no fue utilizada (no posee movimientos).
Las tarjetas se identifican por un número de 16 dígitos. Los primeros números cambian de
acuerdo con el tipo de tarjeta. En el caso de las Platinum comienzan con 9999, las Gold con 8888
y las Plata con 7777. Los números de tarjeta deben validarse cuando se ingresan y no se debe
permitir valores incorrectos. Las tarjetas también poseen una fecha de otorgamiento y otra fecha
de vencimiento.
Los titulares se identifican por su tipo y número de documento, de los titulares también se desea
saber el nombre y el apellido.
A las tarjetas se les pueden generar consumos en pesos o dólares. Los consumos se generan
oprimiendo botones, uno para consumos en pesos u otro para consumos en dólares.
Cada tarjeta posee un límite de consumo en pesos y otro en dólares que no se pueden exceder. En
caso de que esto suceda de deben desencadenar eventos personalizados. Uno para el exceso de
consumos en pesos y otro para el exceso de consumos en dólares. Los eventos personalizados
deben llevar como argumento el importe de consumo que no se pudo gestionar porque produce el
exceso que supera lo permitido.
A una tarjeta se le pueden realizar pagos que reducen el saldo consumido. Estos pagos pueden
ser en pesos o dólares. Los pagos en pesos reducen el consumido en pesos y los pagos en dólares
reducen el consumido en dólares. Cuando se realizan pagos se cobra un gasto administrativo que
Programación I / Pág. 3
es un porcentaje. Este porcentaje se calcula sobre el pago realizado y reduce del importe que se
paga según el siguiente cuadro:

Platinum Gold Plata
Pesos 10 % 20 % 30 %
Dólares 1 % 2 % 3 %
