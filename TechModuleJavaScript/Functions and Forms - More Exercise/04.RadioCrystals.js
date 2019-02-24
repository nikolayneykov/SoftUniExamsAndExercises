function processCrystals(crystals) {
    let transportAndWash = x => Math.floor(x);
    let operations = new Map([  
        ['Cut', x => x / 4],
        ['Lap', x => x * 0.8],
        ['Grind', x => x - 20],
        ['Etch', x => x - 2],
        ['X-ray', x => x + 1]
    ]);

    let targetThickness = crystals.shift(); 

    for (let crystal of crystals) {     
        console.log(`Processing chunk ${crystal} microns`);
        for (let [name, operation] of operations) {  
            let cnt = 0; 
            if (name !== 'X-ray' && name !== 'Etch' &&  
                operations.get(name)(crystal) >= targetThickness) { 

                while (operations.get(name)(crystal) >= targetThickness) { 
                    crystal = operations.get(name)(crystal);   
                    cnt++;
                }

                crystal = transportAndWash(crystal);           
                console.log(`${name} x${cnt}\nTransporting and washing`); 
            } else if (name === 'Etch' && crystal > targetThickness) {
                
                while (crystal > targetThickness) {
                    crystal = operations.get(name)(crystal);
                    cnt++;
                }
                
                crystal = transportAndWash(crystal);
                console.log(`${name} x${cnt}\nTransporting and washing`);

            } else if (name === 'X-ray' && crystal === targetThickness - 1) {
                crystal = operations.get(name)(crystal);
                console.log(`${name} x1`);
            }
        }

        console.log(`Finished crystal ${crystal} microns`);
    }
}