# eSportskeNovosti
eSportskeNovosti a faculty project for Razvoj Softvera 2 

Hi everyone!

This is for my university project. This repository is only for Windows Form and API. I also have a Flutter part which you can find [here](https://github.com/Comlaa/esnflutter).

## Docker
Please ensure to pull the latest image.

Run

```
docker-compose up

```

API and the SQL server are both hosted on docker. To connect to the SQL database, you can use this login data:
User=sa; Password =Plavi.12!

Since, API part is hosted on docker, I mapped the ports to 8012, so you can test the endpoints on the [Swagger UI](http://localhost:8012/swagger/index.html). 


## Login data
When you first run the project, you will see that the project has seed data. Here are 3 different users that you can test the application with. I suggest using 'korisnik' on the Flutter app and 'Desktop' on the Windows Forms one.

1. desktop, pw: test - Admin role
2. mobile, pw: test - Admin role
3. korisnik, pw: test - User role
