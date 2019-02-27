function printFlightTable([action,townName,time,flight,gate]) {
    console.log(`${action}: Destination - ${townName}, Flight - ${flight}, Time - ${time}, Gate - ${gate}`);
}

printFlightTable(['Departures', 'London', '22:45', 'BR117', '42'])