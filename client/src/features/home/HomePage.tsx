import Hero from '../../components/Hero'
import HeroImage from '../../img/home.jpeg'

export default function HomePage() {
  return (
    <>
      <Hero
        Title="E-commerce"
        destakTitle="Peg"
        subTitle="Welcome and Good Shopping!"
        imageHero={HeroImage}
        boxTitle='Trending Styles'
        boxSub='Life is boring without Pets!'
        boxText='We love to pamper your pets'
      />
    </>
  )
}
