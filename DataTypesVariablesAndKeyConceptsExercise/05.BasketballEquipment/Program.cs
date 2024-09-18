//•	Basketball sneakers – their price is 40% less than the fee for one year
//•	Basketball uniform – its price is 20% cheaper than that of sneakers
//•	Basketball ball – its price is 1 / 4 of the price of the basketball uniform
//•	Basketball accessories – their price is 1 / 5 of the price of the basketball ball
//•	The annual basketball training fee – an integer in the range [0... 9999]•	The annual basketball training fee – an integer in the range [0... 9999]


int trainingFee = int.Parse(Console.ReadLine());

double basketballSneakers = trainingFee * 0.6;
double uniform = basketballSneakers * 0.80;
double basketballBall = uniform / 4;
double accessories = basketballBall / 5;

double totalPrice = trainingFee + basketballSneakers + uniform + basketballBall + accessories;


Console.WriteLine(totalPrice);
