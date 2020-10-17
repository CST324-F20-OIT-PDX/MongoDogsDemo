This is a demo C#-> Mongo console app for CST324

Note:  I'm a C++ programmer.  I am a good programmer, so I can pick up other languages fast.  AND, I may not be following all standard practice for C#.   If you see something that is weird for C#, then send me a polite email.  If you are  a student you can get some extra credit.

# My Steps

1. Export a subset of the DogsOfZurichExample as a CSV and futz a little. 
2. Import the CSV into my local MongoDB.  (_id was an objectid, OwnerID an Int32 and DogYearOfBirth an Int32)
3. Start this readme. 
4. Add the mongo NuGet package.
5. Add the mongo includes.
6. Created the class for the database with a standard LoadRecords.
7. Created the all in model for dogs
8. Loaded the database and printed out a count of the records.
9. Moved my DB and my DogModel to their own c lass and made it more specific (less generic)
10. Did a filter Query for breed
11. Did a linq Query for Breed
12. Did a breed print method
13. Cleanup!
