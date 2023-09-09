#include <LiquidCrystal_I2C.h>
#include<Servo.h>

int potentiometer = A7;

LiquidCrystal_I2C lcd(0x27, 20,4);
Servo servoku;
int redLED = 2;
int greenLED = 7;
int blueLED = 12;

String receivedData = "";

void setup() 0
{
  Serial.begin(9600);
  lcd.init();
  lcd.backlight();
  lcd.setCursor(0,1);

  pinMode(greenLED, OUTPUT);
  pinMode(blueLED, OUTPUT);
  pinMode(redLED, OUTPUT);
  servoku.attach(11);
  servoku.write(0);
}

void loop() 
{
  if(Serial.available())
  {
    lcd.setCursor(0,1);
    
    while(Serial.available() > 0)
    {
      char data = Serial.read();

      if (data == '\n') 
      {
        servoku.write(receivedData.toInt());
        receivedData = "";
        lcd.clear();
      } 
      else 
      {
        receivedData += data;
        if (receivedData.startsWith("GON") || receivedData.startsWith("GOFF")) 
        {
          digitalWrite(greenLED, receivedData.startsWith("GON") ? HIGH : LOW);
          lcd.clear();
        }
        else if (receivedData.startsWith("BON") || receivedData.startsWith("BOFF")) 
        {
          digitalWrite(blueLED, receivedData.startsWith("BON") ? HIGH : LOW);
          lcd.clear();
        }
        else if (receivedData.startsWith("RON") || receivedData.startsWith("ROFF")) 
        {
          digitalWrite(redLED, receivedData.startsWith("RON") ? HIGH : LOW);
          lcd.clear();
        }
        else if(receivedData.equals("clr"))
        {
          lcd.clear();
        }
        else
        { 
          lcd.write(data);
        }    
      }
    }
    receivedData = "";
  }
  int data = analogRead(potentiometer);
  int percentage = map(data, 0, 1023, 0, 100);
  Serial.println(percentage);
  delay(80);
}
