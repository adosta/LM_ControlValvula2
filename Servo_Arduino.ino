#include <Servo.h>

Servo servoMotor;
int servoPin=13;
int value=0;
int angle;
int x;

void setup(){
  Serial.begin(9600);
  servoMotor.attach(servoPin);
}

void loop(){
  if(Serial.available() >0) 
  {
    value = Serial.read();
    if(value>0){
      x=value;
    }
  }
  else if (x>=0 && x<=180){
    angle=x;
    servoMotor.write(angle); 
  }
}
