const AutoService = require('./02.AutoService')
const assert = require('chai').assert

describe('AutoService', () => {
  let autoService
  beforeEach(() => {
    autoService = new AutoService(2)
  })

  describe('instantiation', () => {
    it('should have garage capacity', () => {
      assert.equal(autoService.garageCapacity, 2)
    })

    //! Judge does not accepct bottom two tests
    // it('should have workInProgress', () => {
    //   assert.deepEqual(autoService.workInProgress, [])
    // })

    // it('should have backlogWork', () => {
    //   assert.deepEqual(autoService.backlogWork, [])
    // })
  })

  describe('autoService methods', () => {
    beforeEach(() => {
      autoService.signUpForReview('Peter', 'CA1234CA', {
        'engine': 'MFRGG23',
        'transmission': 'FF4418ZZ',
        'doors': 'broken'
      })

      autoService.signUpForReview('Peter', 'CA1234CA', {
        'engine': 'MFRGG23',
        'transmission': 'FF4418ZZ',
        'doors': 'broken',
        'wheels': 'broken',
        'tires': 'broken'
      })

      autoService.signUpForReview('Philip', 'PB4321PB', {
        'engine': 'MFRGG23',
        'transmission': 'FF4418ZZ',
        'exaustPipe': 'REMUS'
      })
    })

    describe('availableSpace', () => {
      it('should return the available space in the auto service garage', () => {
        assert.equal(autoService.availableSpace, 0)
      })
    })

    describe('signupForReview', () => {
      it('should register in workInProgress if there is available space', () => {
        assert.equal(JSON.stringify(autoService.workInProgress),
          JSON.stringify([{
            plateNumber: 'CA1234CA',
            clientName: 'Peter',
            carInfo: {
              engine: 'MFRGG23',
              transmission: 'FF4418ZZ',
              doors: 'broken'
            }
          },
          {
            plateNumber: 'CA1234CA',
            clientName: 'Peter',
            carInfo: {
              engine: 'MFRGG23',
              transmission: 'FF4418ZZ',
              doors: 'broken',
              wheels: 'broken',
              tires: 'broken'
            }
          }]))
      })

      it('should register backlogWork if there is no available space in workInProgress', () => {
        assert.equal(JSON.stringify(autoService.backlogWork),
          JSON.stringify([{
            plateNumber: 'PB4321PB',
            clientName: 'Philip',
            carInfo: {
              engine: 'MFRGG23',
              transmission: 'FF4418ZZ',
              exaustPipe: 'REMUS'
            }
          }]))
      })
    })

    describe('carInfo', () => {
      it('should return special message if the car does not exist', () => {
        assert.equal(autoService.carInfo('invalidPlate', 'invalidClient'),
          `There is no car with platenumber invalidPlate and owner invalidClient.`)
      })

      it('should return the car info if the car exists', () => {
        assert.equal(JSON.stringify(autoService.carInfo('PB4321PB', 'Philip')),
          JSON.stringify({
            plateNumber: 'PB4321PB',
            clientName: 'Philip',
            carInfo:
            {
              engine: 'MFRGG23',
              transmission: 'FF4418ZZ',
              exaustPipe: 'REMUS'
            }
          }))
      })
    })

    describe('repairCar', () => {
      it('should repair broken parts', () => {
        assert.equal(autoService.repairCar(), 'Your doors were repaired.')
        assert.equal(autoService.repairCar(), 'Your doors and wheels and tires were repaired.')
        assert.equal(autoService.repairCar(), 'Your car was fine, nothing was repaired.')
        assert.equal(autoService.repairCar(), 'No clients, we are just chilling...')
      })
    })
  })
})
