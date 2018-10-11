# Biluthyrning

3 models
10 cars
0-8 hours

Cars are picked up and left at the company (no address needed)

## Site Layout

### Layout
* navigation (Home, booking, register?)
* footer (copyright?)

### Home
* welcome
* info

### Booking 
* list of cars
  * available (if empty show text)
  * booked (show time until available) (if empty show text)
* time
* book (send to registraition page)

#### successful booking
sent here after booking
* success
* show relevant user information (name)
* show relevant booking information (time booked )
* show relevent car information (model, color)

#### Registraition
* Name
* E-mail
* Phone number
* körkorts uppgifter
* register (send to succesful booking page)


## model
### Car
#### properties:
* string    model 
* string    color
* string    registryNumber

### customer
* string    name
* string    E-mail
* string    phone-number
* körkortsuppgifter

### booking
* car
* customer
* FromBookDate
* ToBookDate

