const SoftUniFy = require('./03.Softunify')
const assert = require('chai').assert

describe('SoftUniFy', () => {
  let sofunify = null
  beforeEach(() => {
    sofunify = new SoftUniFy()
  })

  describe('allSongs', () => {
    it('should contain allSongs property on initialization', () => {
      assert.hasAllKeys(sofunify, 'allSongs')
    })
  })

  describe('downloadSong', () => {
    it('should adds the given information to the allSongs property', () => {
      sofunify.downloadSong('Eminem', 'Venom', 'Knock, Knock let the devil in...')
      sofunify.downloadSong('Eminem', 'Phenomenal', 'IM PHENOMENAL...')
      sofunify.downloadSong('Dub Fx', 'Light Me On Fire', 'You can call me a liar.. ')

      let expected = JSON.stringify({
        Eminem:
        {
          rate: 0,
          votes: 0,
          songs:
            ['Venom - Knock, Knock let the devil in...',
              'Phenomenal - IM PHENOMENAL...']
        },
        'Dub Fx':
        {
          rate: 0,
          votes: 0,
          songs: ['Light Me On Fire - You can call me a liar.. ']
        }
      })

      assert.equal(JSON.stringify(sofunify.allSongs), expected)
    })
  })

  describe('playSong', () => {
    it('should return special message if searched song is not found', () => {
      assert.equal(sofunify.playSong('test'),
        'You have not downloaded a test song yet. ' +
        'Use SoftUniFy\'s function downloadSong() to change that!')
    })

    it('should return searched song', () => {
      sofunify.downloadSong('Eminem', 'Venom', 'Knock, Knock let the devil in...')
      let expected = 'Eminem:\nVenom - Knock, Knock let the devil in...\n'
      assert.equal(sofunify.playSong('Venom'), expected)
    })
  })

  describe('songsList', () => {
    it('should return special message if there are no downloaded songs', () => {
      assert.equal(sofunify.songsList, 'Your song list is empty')
    })

    it('should get all already downloaded songs ', () => {
      sofunify.downloadSong('Eminem', 'Venom', 'Knock, Knock let the devil in...')
      sofunify.downloadSong('Eminem', 'Phenomenal', 'IM PHENOMENAL...')
      sofunify.downloadSong('Dub Fx', 'Light Me On Fire', 'You can call me a liar.. ')

      let expected = 'Venom - Knock, Knock let the devil in...\n' +
        'Phenomenal - IM PHENOMENAL...\n' +
        'Light Me On Fire - You can call me a liar.. '

      assert.equal(sofunify.songsList, expected)
    })
  })

  describe('rateArtist', () => {
    it('should return special message if artist is not found', () => {
      assert.equal(sofunify.rateArtist('Test'), 'The Test is not on your artist list.')
    })

    it('should return average rate of the artist', () => {
      sofunify.downloadSong('Eminem', 'Venom', 'Knock, Knock let the devil in...')
      assert.equal(sofunify.rateArtist('Eminem', 10), 10)
      assert.equal(sofunify.rateArtist('Eminem', 1), 5.5)
    })
  })
})
