import _mysql_connector as db
import time as t
import datetime as dt
from dbConnect import getConnect

mydb = getConnect()

def get_stamp():
    yy = dt.datetime.today().year
    mm = dt.datetime.today().month
    dd = dt.datetime.today().day
    hh = dt.datetime.today().hour
    m = dt.datetime.today().minute
    ss = dt.datetime.today().second
    #print(str(yy), str(mm), str(dd), str(hh), str(m), str(ss))
    Tstamp = (str(yy)+str(mm)+str(dd)+str(hh)+str(m)+str(ss))
    return Tstamp

def insert(plate,stamp, desig):
    t_in = dt.datetime.now()
    
    #number = '0'
    try:
        
        query ="INSERT INTO parking (number_plate, time_in, time_out,designation, stamp, status) VALUES ('"+ plate +"', '"+str(t_in)+"', '0000-00-00 00:00:00', '"+desig+"', '"+stamp+"', 'IN')"
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

#updating counter table for dashboard visuals
#function is triggered when a car is entering the residence complex
def update_counter_in(designation):
    lot_id = '220010001'
    def getnums():
        query = "SELECT empty_slots, visitors, residents FROM counters WHERE lot_id = '220010001'"
        try:
            cursor = mydb.cursor()
            cursor.execute(query)
            data = cursor.fetchall()
            data = list(data)
            out = [item for t in data for item in t]
            print(out)
            print(type(out))
            cursor.close()
            return out[0], out[1], out[2]
        except db.Error as error:
            print("Failed to get record from table{}".format(error))
    
    free,vis,res = getnums()
    nfree = free - 1
    
    #updating count for residence already parked and number of slots available
    #add  1 to residents parked and subtract 1 from available slots
    if designation == 'resident':
        nres = res + 1
        query = "UPDATE counters set empty_slots = '"+str(nfree)+"', residents = '"+str(nres)+"' WHERE lot_id = '220010001'"
        try:
            cursor = mydb.cursor()
            cursor.execute(query)
            mydb.commit()
            print(cursor.rowcount, "Record was successfully updated")
            cursor.close()
        except db.Error as error:
            print("Failed to update record{}".format(error))
    else:
        #update number of visitors and slots available
        #Add 1 to visitors and subtract 1 from available slots
        nvis = vis + 1
        query = "UPDATE counters set empty_slots = '"+str(nfree)+"', visitors = '"+str(nvis)+"' WHERE lot_id = '220010001'"
        try:
            cursor = mydb.cursor()
            cursor.execute(query)
            mydb.commit()
            print(cursor.rowcount, "Record was updated sucessfully.")
            cursor.close()
        except db.Error as error:
            print("Failed to update record{}".formart(error))
            
#updating counts when a car is exiting the residence compound

def update_counter_out(designation):
    lot_id = '220010001'
    def getnums():
        query = "SELECT empty_slots, visitors, residents FROM counters WHERE lot_id = '220010001'"
        try:
            cursor = mydb.cursor()
            cursor.execute(query)
            data = cursor.fetchall()
            data = list(data)
            out = [item for t in data for item in t]
            print(out)
            print(type(out))
            cursor.close()
            return out[0], out[1], out[2]
        except db.Error as error:
            print("Failed to get record from table{}".format(error))
    
    free,vis,res = getnums()
    nfree = free + 1
    #less 1 from residents total and add 1 to available slots
    if designation == 'resident':
        nres = res - 1
        query = "UPDATE counters set empty_slots = '"+str(nfree)+"', residents = '"+str(nres)+"' WHERE lot_id = '220010001'"
        try:
            cursor = mydb.cursor()
            cursor.execute(query)
            mydb.commit()
            print(cursor.rowcount, "Record was successfully updated")
            cursor.close()
        except db.Error as error:
            print("Failed to update record{}".format(error))
    else:
        #less one from visitors total and add one to available slots
        nvis = vis - 1
        query = "UPDATE counters set empty_slots = '"+str(nfree)+"', visitors = '"+str(nvis)+"' WHERE lot_id = '220010001'"
        try:
            cursor = mydb.cursor()
            cursor.execute(query)
            mydb.commit()
            print(cursor.rowcount, "Record was updated sucessfully.")
            cursor.close()
        except db.Error as error:
            print("Failed to update record{}".formart(error))

#get the parking record ID when a car is exiting the residence
def get_idxout(x):
	statement = "SELECT id, time_in FROM parking WHERE number_plate = '"+x+"' AND status = 'IN'"
	try:
		cursor = mydb.cursor()
		cursor.execute(statement)
		data = cursor.fetchall()
		data = list(data)
		out = [item for t in data for item in t]
		print(out)
		print(type(out))
		cursor.close()
		return out[0]   #return the ID of the current parking record
		
	
	except db.Error as error:
		print("Failed to get record from table{}".format(error))

#check if the parking record is available in the parking table 
def checkExt(idx):
    query = "SELECT designation FROM parking WHERE id = '"+str(idx)+"' and status = 'IN'"
    try:
        cursor = mydb.cursor()
        cursor.execute(query)
        data = cursor.fetchall()
        data = list(data)
        out = [item for t in data for item in t]
        if len(data) <= 0:
            return 'error','nil'
        else:
            return 'go', out[0]
    except db.Error as error:
        print("Failed to connect to db{}".format(error))
            

#update the parking table and set parking status to out when a car leaves the residence
def update_out(idx):
    #number = '1'
    t_out = dt.datetime.now()
    #t = str(t_out)
    try:
        query = "UPDATE parking SET time_out = '"+str(t_out)+"', status = 'OUT'WHERE id = '"+str(idx)+"'"
        cursor = mydb.cursor()
        cursor.execute(query)
        mydb.commit()
        print(cursor.rowcount, "Record was successfully updated")
        cursor.close()
    except db.Error as error:
        print("Failed toupdate record{}".format(error))
