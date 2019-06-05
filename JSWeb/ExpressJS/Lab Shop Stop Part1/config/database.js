let products = [
  {
    name:
      'Anker Sound Surge Bluetooth Headphones Buds In Ear Magnetic Headphones with 6 Hours Playing Time/Waterproof IPX4/MIC FOR IPHONE, IPAD, SAMSUNG, NEXUS, HTC and More ',
    description: ` High-Fidelity Audio: Powered by 6mm drivers delivering crystal clear sound.
    Tailored to You: Built-in WingTips give earphones a comfortable, yet secure fit while exercising.
    Safe and Sound: Wherever you store them, in-built magnets attach your earphones securely together for safekeeping.
    No Sweat: Water-resistant nano-coating ensures sweat stays out of your earphones throughout workouts.
    What You Get: SoundBuds Surge, Multiple EarTips, Multiple Wingtips, Cord Management Clip, Shirt Clip, Carrying Pouch, our worry-free 18 month warranty and friendly customer service.`,
    price: 17.59,
    image:
      'https://images-na.ssl-images-amazon.com/images/I/517gaIhOTSL._SL1200_.jpg'
  },
  {
    name: 'BASN Earbud Earphones with Microphone Tangle Free in-ear Headphones',
    description: ` 10mm high sensitivity powerful big speakers, balanced audio with clear crisp sound, optimized to have better Deep Bass
    In-line microphone for hands-free calls, tangel-free 1.2 m flat cable with longer life time
    Stereo 3.5mm jack compatible with iPhone, iPad, iPod, Mp3 players, Android Smartphones
    Multi-function button one click for PLAY/PAUSE music, ANSWER/END calls, double click for NEXT track; triple click for PREV track
    High quality silicon eartips block out noises with comfortable and secure fit`,
    price: 6.29,
    image:
      'https://images-na.ssl-images-amazon.com/images/I/61Jmy4xPM8L._SL1299_.jpg'
  },
  {
    name: 'Betron AX1 Noise Isolating Earphones Headphones with Microphone Bass Driven Sound (Black Gold) ',
    description: ` Noise isolating ( passive noise cancelling) in ear headphones earphones
    Bass driven sound, feel the power of music
    Microphone and one button remote control let you take calls, play and pause your music on the move
    Ideal for Apple iPhone, iPad, iPod, Samsung, Nokia, Sony, Google Pixel Smartphones, MP3 Players, tablets and more
    3 sizes of silicon earbuds and cable clip included for ultimate comfort; 1 year warranty for manufacturing defects, 30 days satisfaction guarantee`,
    price: 9.99,
    image:
      'https://images-na.ssl-images-amazon.com/images/I/71ihoGk4u5L._SL1500_.jpg'
  }
]
let count = 1

module.exports.products = {
  getAll () {
    return products
  },
  add (product) {
    product.id = count++
    products.push(product)
  },
  findByName (name) {
    return products.filter(p =>
      p.name.toLowerCase().includes(name.toLowerCase())
    )
  }
}
