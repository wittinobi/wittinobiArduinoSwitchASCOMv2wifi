/*
 Name:		wittinobiArduinoSwitchASCOMv2wifiINO.ino
 Created:	26.06.2022 23:58:03
 Author:	Tobias Wittmann (wittinobi)
*/

#include <ESP8266WiFi.h>

const char* WIFI_NAME = "YOUR-WIFI-NETWORK-NAME (SSID)"; // Replace with your own WIFI-NAME (SSID) !!!
const char* WIFI_PASSWORD = "YOUR-WIFI-NETWORK-PASSWORD"; // Replace with your own WIFI-PASSWORD !!!
WiFiServer Server(80);

String Header;

String MaxSwitch = "8";

String RELAY_1_STATE = "OFF";
String RELAY_2_STATE = "OFF";
String RELAY_3_STATE = "OFF";
String RELAY_4_STATE = "OFF";
String RELAY_5_STATE = "OFF";
String RELAY_6_STATE = "OFF";
String RELAY_7_STATE = "OFF";
String RELAY_8_STATE = "OFF";

const int GPIO_PIN_NUMBER_1 = D3; // ARDUINO ESP8266 (ESP12) PIN D3 
const int GPIO_PIN_NUMBER_2 = D4; // ARDUINO ESP8266 (ESP12) PIN D4
const int GPIO_PIN_NUMBER_3 = D5; // ARDUINO ESP8266 (ESP12) PIN D5
const int GPIO_PIN_NUMBER_4 = D6; // ARDUINO ESP8266 (ESP12) PIN D6
const int GPIO_PIN_NUMBER_5 = D7; // ARDUINO ESP8266 (ESP12) PIN D7
const int GPIO_PIN_NUMBER_6 = D8; // ARDUINO ESP8266 (ESP12) PIN D8
const int GPIO_PIN_NUMBER_7 = D9; // ARDUINO ESP8266 (ESP12) PIN RX
const int GPIO_PIN_NUMBER_8 = D10; // ARDUINO ESP8266 (ESP12) PIN TX

void setup()
{
    pinMode(GPIO_PIN_NUMBER_1, OUTPUT);
    pinMode(GPIO_PIN_NUMBER_2, OUTPUT);
    pinMode(GPIO_PIN_NUMBER_3, OUTPUT);
    pinMode(GPIO_PIN_NUMBER_4, OUTPUT);
    pinMode(GPIO_PIN_NUMBER_5, OUTPUT);
    pinMode(GPIO_PIN_NUMBER_6, OUTPUT);
    pinMode(GPIO_PIN_NUMBER_7, OUTPUT);
    pinMode(GPIO_PIN_NUMBER_8, OUTPUT);

    digitalWrite(GPIO_PIN_NUMBER_1, HIGH);
    digitalWrite(GPIO_PIN_NUMBER_2, HIGH);
    digitalWrite(GPIO_PIN_NUMBER_3, HIGH);
    digitalWrite(GPIO_PIN_NUMBER_4, HIGH);
    digitalWrite(GPIO_PIN_NUMBER_5, HIGH);
    digitalWrite(GPIO_PIN_NUMBER_6, HIGH);
    digitalWrite(GPIO_PIN_NUMBER_7, HIGH);
    digitalWrite(GPIO_PIN_NUMBER_8, HIGH);

    WiFi.begin(WIFI_NAME, WIFI_PASSWORD);
    while (WiFi.status() != WL_CONNECTED)
    {
        delay(1000);
    }
    Server.begin();
}

void loop()
{
    WiFiClient Client = Server.available();
    if (Client)
    {
        String current_data_line = "";
        while (Client.connected())
        {
            if (Client.available())
            {
                char new_byte = Client.read();
                Header += new_byte;
                if (new_byte == '\n')
                {
                    if (current_data_line.length() == 0)
                    {
                        Client.println("HTTP/1.1 200 OK");
                        Client.println("Content-type:text/html");
                        Client.println("Connection: close");
                        Client.println();
                        if (Header.indexOf("MAXSWITCH=1") >= 0)
                        {
                            MaxSwitch = "1";
                        }
                        if (Header.indexOf("MAXSWITCH=2") >= 0)
                        {
                            MaxSwitch = "2";
                        }
                        if (Header.indexOf("MAXSWITCH=3") >= 0)
                        {
                            MaxSwitch = "3";
                        }
                        if (Header.indexOf("MAXSWITCH=4") >= 0)
                        {
                            MaxSwitch = "4";
                        }
                        if (Header.indexOf("MAXSWITCH=5") >= 0)
                        {
                            MaxSwitch = "5";
                        }
                        if (Header.indexOf("MAXSWITCH=6") >= 0)
                        {
                            MaxSwitch = "6";
                        }
                        if (Header.indexOf("MAXSWITCH=7") >= 0)
                        {
                            MaxSwitch = "7";
                        }
                        if (Header.indexOf("MAXSWITCH=8") >= 0)
                        {
                            MaxSwitch = "8";
                        }
                        if (Header.indexOf("RELAY1=ON") >= 0)
                        {
                            RELAY_1_STATE = "ON";
                            digitalWrite(GPIO_PIN_NUMBER_1, LOW);
                        }
                        if (Header.indexOf("RELAY1=OFF") >= 0)
                        {
                            RELAY_1_STATE = "OFF";
                            digitalWrite(GPIO_PIN_NUMBER_1, HIGH);
                        }
                        if (Header.indexOf("RELAY2=ON") >= 0)
                        {
                            RELAY_2_STATE = "ON";
                            digitalWrite(GPIO_PIN_NUMBER_2, LOW);
                        }
                        if (Header.indexOf("RELAY2=OFF") >= 0)
                        {
                            RELAY_2_STATE = "OFF";
                            digitalWrite(GPIO_PIN_NUMBER_2, HIGH);
                        }
                        if (Header.indexOf("RELAY3=ON") >= 0)
                        {
                            RELAY_3_STATE = "ON";
                            digitalWrite(GPIO_PIN_NUMBER_3, LOW);
                        }
                        if (Header.indexOf("RELAY3=OFF") >= 0)
                        {
                            RELAY_3_STATE = "OFF";
                            digitalWrite(GPIO_PIN_NUMBER_3, HIGH);
                        }
                        if (Header.indexOf("RELAY4=ON") >= 0)
                        {
                            RELAY_4_STATE = "ON";
                            digitalWrite(GPIO_PIN_NUMBER_4, LOW);
                        }
                        if (Header.indexOf("RELAY4=OFF") >= 0)
                        {
                            RELAY_4_STATE = "OFF";
                            digitalWrite(GPIO_PIN_NUMBER_4, HIGH);
                        }
                        if (Header.indexOf("RELAY5=ON") >= 0)
                        {
                            RELAY_5_STATE = "ON";
                            digitalWrite(GPIO_PIN_NUMBER_5, LOW);
                        }
                        if (Header.indexOf("RELAY5=OFF") >= 0)
                        {
                            RELAY_5_STATE = "OFF";
                            digitalWrite(GPIO_PIN_NUMBER_5, HIGH);
                        }
                        if (Header.indexOf("RELAY6=ON") >= 0)
                        {
                            RELAY_6_STATE = "ON";
                            digitalWrite(GPIO_PIN_NUMBER_6, LOW);
                        }
                        if (Header.indexOf("RELAY6=OFF") >= 0)
                        {
                            RELAY_6_STATE = "OFF";
                            digitalWrite(GPIO_PIN_NUMBER_6, HIGH);
                        }
                        if (Header.indexOf("RELAY7=ON") >= 0)
                        {
                            RELAY_7_STATE = "ON";
                            digitalWrite(GPIO_PIN_NUMBER_7, LOW);
                        }
                        if (Header.indexOf("RELAY7=OFF") >= 0)
                        {
                            RELAY_7_STATE = "OFF";
                            digitalWrite(GPIO_PIN_NUMBER_7, HIGH);
                        }
                        if (Header.indexOf("RELAY8=ON") >= 0)
                        {
                            RELAY_8_STATE = "ON";
                            digitalWrite(GPIO_PIN_NUMBER_8, LOW);
                        }
                        if (Header.indexOf("RELAY8=OFF") >= 0)
                        {
                            RELAY_8_STATE = "OFF";
                            digitalWrite(GPIO_PIN_NUMBER_8, HIGH);
                        }
                        Client.println("<!DOCTYPE html><html>");
                        Client.println("<head><meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">");
                        Client.println("<link rel=\"icon\" href=\"data:,\">");
                        Client.println("<style>html { font-family: Helvetica; display: inline-block; margin: 0px auto; text-align: center;}");
                        Client.println(".button { background-color: #4CAF50; border: 2px solid #4CAF50;; color: white; padding: 10px 32px; text-align: center; text-decoration: none; display: inline-block; font-size: 12px; margin: 4px 2px; cursor: pointer; }");
                        Client.println("text-decoration: none; font-size: 20px; margin: 2px; cursor: pointer;}");
                        Client.println("</style></head>");
                        Client.println("<body><center><h1>wittinobiArduinoSwitchASCOMv2wifiINO</h1></center>");
                        Client.println("<center><h2>ESP8266 (ESP12) WebServer</h2></center>");
                        Client.println("<form><center><br><br>");
                        if (MaxSwitch.toInt() >= 1)
                        {
                            Client.println("RELAY 1 is " + RELAY_1_STATE + "<br>");
                            Client.println("<button class=\"button\" name=\"RELAY1\" value=\"ON\" type=\"submit\">RELAY1 ON</button>");
                            Client.println("<button class=\"button\" name=\"RELAY1\" value=\"OFF\" type=\"submit\">RELAY1 OFF</button><br><br>");
                        }
                        if (MaxSwitch.toInt() >= 2)
                        {
                            Client.println("RELAY 2 is " + RELAY_2_STATE + "<br>");
                            Client.println("<button class=\"button\" name=\"RELAY2\" value=\"ON\" type=\"submit\">RELAY2 ON</button>");
                            Client.println("<button class=\"button\" name=\"RELAY2\" value=\"OFF\" type=\"submit\">RELAY2 OFF</button><br><br>");
                        }
                        if (MaxSwitch.toInt() >= 3)
                        {
                            Client.println("RELAY 3 is " + RELAY_3_STATE + "<br>");
                            Client.println("<button class=\"button\" name=\"RELAY3\" value=\"ON\" type=\"submit\">RELAY3 ON</button>");
                            Client.println("<button class=\"button\" name=\"RELAY3\" value=\"OFF\" type=\"submit\">RELAY3 OFF</button><br><br>");
                        }
                        if (MaxSwitch.toInt() >= 4)
                        {
                            Client.println("RELAY 4 is " + RELAY_4_STATE + "<br>");
                            Client.println("<button class=\"button\" name=\"RELAY4\" value=\"ON\" type=\"submit\">RELAY4 ON</button>");
                            Client.println("<button class=\"button\" name=\"RELAY4\" value=\"OFF\" type=\"submit\">RELAY4 OFF</button><br><br>");
                        }
                        if (MaxSwitch.toInt() >= 5)
                        {
                            Client.println("RELAY 5 is " + RELAY_5_STATE + "<br>");
                            Client.println("<button class=\"button\" name=\"RELAY5\" value=\"ON\" type=\"submit\">RELAY5 ON</button>");
                            Client.println("<button class=\"button\" name=\"RELAY5\" value=\"OFF\" type=\"submit\">RELAY5 OFF</button><br><br>");
                        }
                        if (MaxSwitch.toInt() >= 6)
                        {
                            Client.println("RELAY 6 is " + RELAY_6_STATE + "<br>");
                            Client.println("<button class=\"button\" name=\"RELAY6\" value=\"ON\" type=\"submit\">RELAY6 ON</button>");
                            Client.println("<button class=\"button\" name=\"RELAY6\" value=\"OFF\" type=\"submit\">RELAY6 OFF</button><br><br>");
                        }
                        if (MaxSwitch.toInt() >= 7)
                        {
                            Client.println("RELAY 7 is " + RELAY_7_STATE + "<br>");
                            Client.println("<button class=\"button\" name=\"RELAY7\" value=\"ON\" type=\"submit\">RELAY7 ON</button>");
                            Client.println("<button class=\"button\" name=\"RELAY7\" value=\"OFF\" type=\"submit\">RELAY7 OFF</button><br><br>");
                        }
                        if (MaxSwitch.toInt() >= 8)
                        {
                            Client.println("RELAY 8 is " + RELAY_8_STATE + "<br>");
                            Client.println("<button class=\"button\" name=\"RELAY8\" value=\"ON\" type=\"submit\">RELAY8 ON</button>");
                            Client.println("<button class=\"button\" name=\"RELAY8\" value=\"OFF\" type=\"submit\">RELAY8 OFF</button></center>");
                        }
                        Client.println("</center></form></body></html>");
                        Client.println();
                        break;
                    }
                    else
                    {
                        current_data_line = "";
                    }
                }
                else if (new_byte != '\r')
                {
                    current_data_line += new_byte;
                }
            }
        }
        Header = "";
        Client.stop();
    }
}
