#include <Servo.h>

Servo servo;

void setup()
{
  Serial.begin(9600);
  while (!Serial); //Wait the serial port to connect
}

void loop() {
  if (Serial.available())
  {
    int v = Serial.parseInt();
    if (v>=2000 && v<=7180) //The only valids values
    {
      int n = v % 1000; //Get the last 3 digits
      int s = (v - n)/1000; //Get the first digit
      
      Serial.println(v);
      Serial.print("Servo ");
      Serial.println(s);

      servo.attach(s);
      
      if (n>=0 && n<=180){
        servo.write(n);
        Serial.print(n);
        Serial.println(" degrees");
        }
      else{
        Serial.println("Degress not in an acceptable range");          
        }
    }
    else
    {
      Serial.println("Not a valid number");
    }
    Serial.println("---");
  }
  delay(100);
}
