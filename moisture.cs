int moisturePin = A0;  // Analog input pin for the moisture sensor
int moistureValue = 0; // Variable to store the moisture level

void setup() {
  Serial.begin(9600);
}

void loop() {
  moistureValue = analogRead(moisturePin);
  String moisture = String(moistureValue);
  Particle.publish("moisture", moisture, PRIVATE);
  delay(30000);
}
