import mysql.connector as db
import time as t
import datetime as dt


def getConnect():

    mydb = db.connect(
        host = "SERVER NAME",
        user= "USERNAME",
        password="PASSWORD",
        database="DB_NAME")
    return mydb
# DB = getConnect()
# print(DB)
