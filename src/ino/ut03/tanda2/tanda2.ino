// Used pins
#define SERVO1 3    // Servo motor on pin 3 (orange wire)
#define LEDRED 7    // Red led (brown wire)
#define BTNINC 6    // INCrease BuTtoN on pin 6 (light green wire)
#define LEDBLUE 4   // Blue led (blue wire)
#define BTNDEC 5    // DECrease BuTtoN on pin 5 (green wire)

//2.1
#define SERVO_STEP 2

//2.2
#define LED_MS_ON 1000

#include <Servo.h>

Servo servoMotor1;

int servo1Position;

void setup()
{
  pinMode(LEDRED, OUTPUT);
  pinMode(LEDBLUE, OUTPUT);
  pinMode(BTNINC, INPUT_PULLUP);
  pinMode(BTNDEC, INPUT_PULLUP);

  servoMotor1.attach(SERVO1);

  servo1Position = 0;
  servoMotor1.write(servo1Position);

  digitalWrite(LEDRED, LOW);
  digitalWrite(LEDBLUE, LOW);
}

//2.4
void CheckButton(byte button, byte led, int sign)
{
  if (!digitalRead(button))
  {
    if (sign > 0)
    {
      if (servo1Position < 180)
      {
        servo1Position += SERVO_STEP;
        servoMotor1.write(servo1Position);
        delay(10);
      }
      else
      {
        digitalWrite(led, HIGH);
        delay(LED_MS_ON);
        digitalWrite(led, LOW);
      }
    }
    else
    {
      if (servo1Position > 0)
      {
        servo1Position -= SERVO_STEP;
        servoMotor1.write(servo1Position);
        delay(10);
      }
      else
      {
        digitalWrite(led, HIGH);
        delay(LED_MS_ON);
        digitalWrite(led, LOW);
      }
    }
  }
}

void loop()
{
  delay(10);

  CheckButton(BTNINC, LEDRED, 1);
  CheckButton(BTNDEC, LEDBLUE, -1);
}   