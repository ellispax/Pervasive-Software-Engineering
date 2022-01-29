import _mysql_connector as db
import time as t
import datetime as dt
from dbConnect import getConnect

mydb = getConnect()

def insert(plate):
    t_in = dt.datetime.now()
    
    #number = '0'
    try:
        
        query ="INSERT INTO parking (number_plate, time_in, time_out,designation) VALUES ('"+ plate +"', '"+str(t_in)+"', '0000-00-00 00:00:00', 'resident')"
        cursor=mydb.cursor()#cursor.execute(add_word.format(table=atable).data_word)
        cursor.execute(query)
        mydb.commit()
        print(cursor.rowcount, "Record inserted successfull")
        cursor.close()
    except db.Error as error:
        print("Failed to insert record into table{}".format(error))


#Geting the id of the care that is exiting from the parkings table 
def get_timein(x):
	statement = "SELECT id, time_in FROM parking WHERE number_plate = '"+x+"' AND status = 'IN'"
	try:
		cursor = mydb.cursor()
		cursor.execute(statement)
		data = cursor.fetchall()
		#data = list(data)
		out = [item for t in data for item in t]
		print(out)
		print(type(out))
		cursor.close()
		return out[0] #return the parking record ID
		
	
	except db.Error as error:
		print("Failed to get record from table{}".format(error))


#check if car coming into parking space belongs to a resident.
def check(numPlate):
    try:
        query = "SELECT * FROM members WHERE number_plate = '"+numPlate+"' and active_status = 'Active'"
        cursor = mydb.cursor()
        cursor.execute(query)
        data = cursor.fetchall()
        
        #returns designation to be used in the parking table
        if len(data) <= 0:
            return 'visitor'
        else:
            return 'resident'
    except db.Error as error:
        print("Failed to get record from table{}".format(error))


