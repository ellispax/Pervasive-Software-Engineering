import mysql.connector as db
import time as t
import datetime as dt


def getConnect():

    mydb = db.connect(
        host = "rds-pervasive-proj.cb3epmfrlspm.us-east-2.rds.amazonaws.com",
        user= "admin",
        password="mapakame0605",
        database="pervasivedb")
    return mydb
# DB = getConnect()
# print(DB)