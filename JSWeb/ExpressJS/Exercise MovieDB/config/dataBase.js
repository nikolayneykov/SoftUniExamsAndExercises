let db = [
  {
    id: 1,
    movieTitle: 'Kingsman: The Golden Circle',
    movieYear: 2017,
    moviePoster:
      'https://images-na.ssl-images-amazon.com/images/M/MV5BNTBlOWZhZTctOTY0MC00Y2QyLTljMmYtZDkxZDFlMWU4Y2EyXkEyXkFqcGdeQXVyNDg2MjUxNjM@._V1_SY1000_CR0,0,675,1000_AL_.jpg',
    movieDescription:
      "When their headquarters are destroyed and the world is held hostage, the Kingsman's journey leads them to the discovery of an allied spy organization in the US. These two elite secret organizations must band together to defeat a common enemy."
  },
  {
    id: 2,
    movieTitle: 'Jumanji: Welcome to the Jungle',
    movieYear: 2017,
    moviePoster:
      'https://images-na.ssl-images-amazon.com/images/M/MV5BMTkyNDQ1MDc5OV5BMl5BanBnXkFtZTgwOTcyNzI2MzI@._V1_.jpg',
    movieDescription:
      "Four teenagers discover an old video game console and are literally drawn into the game's jungle setting becoming the adult avatars they choose."
  },
  {
    id: 3,
    movieTitle: 'Rurouni Kenshin',
    movieYear: 2012,
    moviePoster:
      'https://images-na.ssl-images-amazon.com/images/M/MV5BNDgzODM2MjUyMF5BMl5BanBnXkFtZTgwMzg4MjA1OTE@._V1_SY1000_CR0,0,679,1000_AL_.jpg',
    movieDescription:
      'In 1868, after the end of the Bakumatsu war, the former assassin Kenshin Himura promises to defend those in need without killing. Kenshin wanders through Japan with a reverse-edged sword during the transition of the samurai age to the New Age. When Kenshin helps the idealistic Kaoru Kamiya from the gangsters of the powerful opium drug lord Kanryuu Takeda that wants her school for his production of opium, Kaoru invites Kenshin to stay in the school. But the drug chemist Megumi Takani escapes from Kanryuu and seeks shelter in the school. Meanwhile the killer Battosai is murdering police officers and leaving messages attached to their bodies. When Kanryuu poisons the population to get the school, Kenshin and the street fighter Sanosuke Sagara join forces to attack their common enemy.'
  },
  {
    id: 4,
    movieTitle: 'Donnie Darko',
    movieYear: 2001,
    moviePoster:
      'https://images-na.ssl-images-amazon.com/images/M/MV5BZjZlZDlkYTktMmU1My00ZDBiLWFlNjEtYTBhNjVhOTM4ZjJjXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg',
    movieDescription:
      "Donnie Darko doesn't get along too well with his family, his teachers and his classmates; but he does manage to find a sympathetic friend in Gretchen, who agrees to date him. He has a compassionate psychiatrist, who discovers hypnosis is the means to unlock hidden secrets. His other companion may not be a true ally. Donnie has a friend named Frank - a large bunny which only Donnie can see. When an engine falls off a plane and destroys his bedroom, Donnie is not there. Both the event, and Donnie's escape, seem to have been caused by supernatural events. Donnie's mental illness, if such it is, may never allow him to find out for sure."
  },
  {
    id: 5,
    movieTitle: 'Sword of the Stranger',
    movieYear: 2007,
    moviePoster:
      'https://images-na.ssl-images-amazon.com/images/M/MV5BNTg2NzBmYTEtMTdiNS00OTg0LWJmMzMtYTZhYzY2MjBlMjFmXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SY1000_CR0,0,675,1000_AL_.jpg',
    movieDescription:
      'A young boy and his dog find themselves the target of the Ming: a foreign dynasty that will stop at nothing. One day, a quiet and solemn warrior crosses their path, and becomes irrevocably connected with the two. A deal is struck and the warrior agrees to take the boy to a remote, Buddhist temple, where a kind monk is waiting to care for him and the dog. Unfortunately, the Ming have sent their elite, and they will test their strength, courage, and quality every step of the way.'
  },
  {
    id: 6,
    movieTitle: 'Die Hard',
    movieYear: 1988,
    moviePoster:
      'https://ia.media-imdb.com/images/M/MV5BMzNmY2IwYzAtNDQ1NC00MmI4LThkOTgtZmVhYmExOTVhMWRkXkEyXkFqcGdeQXVyMTk5NDA3Nw@@._V1_.jpg',
    movieDescription:
      'John McClane, officer of the NYPD, tries to save his wife Holly Gennaro and several others that were taken hostage by German terrorist Hans Gruber during a Christmas party at the Nakatomi Plaza in Los Angeles.'
  },
  {
    id: 7,
    movieTitle: 'Die Hard 2',
    movieYear: 1990,
    moviePoster:
      'https://ia.media-imdb.com/images/M/MV5BMzMzYzk3ZTEtZDg0My00MTY5LWE3ZmQtYzNhYjhjN2RhZGRjL2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SY1000_CR0,0,675,1000_AL_.jpg',
    movieDescription:
      'John McClane attempts to avert disaster as rogue military operatives seize control of Dulles International Airport in Washington, D.C.'
  },
  {
    id: 8,
    movieTitle: 'Die Hard with a Vengeance',
    movieYear: 1995,
    moviePoster:
      'https://ia.media-imdb.com/images/M/MV5BZjI0ZWFiMmQtMjRlZi00ZmFhLWI4NmYtMjQ5YmY0MzIyMzRiXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SY1000_SX670_AL_.jpg',
    movieDescription:
      'John McClane and a Harlem store owner are targeted by German terrorist Simon Gruber in New York City, where he plans to rob the Federal Reserve Building.'
  },
  {
    id: 9,
    movieTitle: 'Deadpool',
    movieYear: '2016',
    moviePoster:
      'https://ia.media-imdb.com/images/M/MV5BYzE5MjY1ZDgtMTkyNC00MTMyLThhMjAtZGI5OTE1NzFlZGJjXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SY1000_CR0,0,666,1000_AL_.jpg',
    movieDescription:
      'A fast-talking mercenary with a morbid sense of humor is subjected to a rogue experiment that leaves him with accelerated healing powers and a quest for revenge.'
  },
  {
    id: 10,
    movieTitle: 'Deadpool 2',
    movieYear: '2018',
    moviePoster:
      'https://ia.media-imdb.com/images/M/MV5BMjI3Njg3MzAxNF5BMl5BanBnXkFtZTgwNjI2OTY0NTM@._V1_SY1000_CR0,0,674,1000_AL_.jpg',
    movieDescription:
      'Foul-mouthed mutant mercenary Wade Wilson (AKA. Deadpool), brings together a team of fellow mutant rogues to protect a young boy with supernatural abilities from the brutal, time-traveling cyborg, Cable.'
  }
]

module.exports = db
