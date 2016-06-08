//Arduio Control
int ledPinRED   = 13;
int ledPinBLUE  = 12;
int ledPinGREEN = 11;
int incomingByte = 0;
//the setup() method runs once, when the sketch starts
void setup() 
{
  //initialize the digital pin as an output
  pinMode(ledPinRED,   OUTPUT);
  pinMode(ledPinBLUE,  OUTPUT);
  pinMode(ledPinGREEN, OUTPUT);
  Serial.begin(9600);
}
//the loop() method runs over and over again,
//as long as the Arduio has power
void loop() 
{
  //read the incoming byte
  incomingByte = Serial.read();
  if (incomingByte != -1);
  {
    Serial.println(incomingByte);
    if (incomingByte == 112)//p
    {
      digitalWrite(ledPinRED, HIGH);
      digitalWrite(ledPinBLUE, LOW);
      digitalWrite(ledPinGREEN, LOW);
    }
    else if (incomingByte ==97)//a
    {
      digitalWrite(ledPinBLUE, HIGH);
      digitalWrite(ledPinRED, LOW);
      digitalWrite(ledPinGREEN, LOW);
    }
    else if (incomingByte == 114)//r
    {
      digitalWrite(ledPinGREEN, HIGH);
      digitalWrite(ledPinRED, LOW);
      digitalWrite(ledPinBLUE, LOW);
    }
    else if (incomingByte == 115)//s
    {
      digitalWrite(ledPinRED, LOW);
      digitalWrite(ledPinBLUE, LOW);
      digitalWrite(ledPinGREEN, LOW);
    }
  }
}
