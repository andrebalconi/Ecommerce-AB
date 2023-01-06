import Card from '@mui/material/Card'
import CardContent from '@mui/material/CardContent'
import CardMedia from '@mui/material/CardMedia'
import Typography from '@mui/material/Typography'
import { Button, CardActionArea, CardActions, Grid } from '@mui/material'
import aboutImage from '../../img/programmer.jpeg'

export default function AboutPage() {
  
  return (
    <>
      <Grid container spacing={4}>
        <Grid item sx={{ width:{ xs: '100%', sm: '70%', md: '40%' }}}>
          <Card sx={{ maxWidth: 600 }}>
            <CardActionArea>
              <CardMedia
                component="img"
                height="600px"
                image={aboutImage}
                alt="André Balconi"
                sx={{ display: 'inLine', width: 1 }}
              />
            </CardActionArea>
          </Card>
        </Grid>
        <Grid item sx={{ width:{ xs: '100%', sm: '70%', md: '60%' }}} >
          <CardContent>
            <Typography gutterBottom variant="h4" component="div">
              Web Developer
            </Typography>
            <Typography variant="body2" color="text.secondary">
              Peg (this Pug on my lap) was the inspiration for this work, she
              keeps me company during the fun hours I spend studying and
              improving my knowledge, this project is just a demonstration for
              future partners and those interested in my work.
              <p>
                I'm a programmer passionate about technology. My experience as a
                developer started in 2006 at the biggest private bank in Brazil,
                working in the automation of processes in the Credit Card
                operation, in the last 6 years, I have been working on
                modernization and website maintenance projects at Mercer Human
                Resource Consulting on Private Pension Fund Management Business.
                My work is not a source of income, it is a source of life! My
                motivation is knowing that with my work I can make people's
                daily lives better, focusing on the customer and continuous
                improvement! I have passion for my work and a lot of willingness
                to share knowledge, which is the best way to acquire more! I am
                looking for opportunities to advance my career and develop my
                skills.
              </p>
            </Typography>
          </CardContent>
          <CardActions>
            <Button
              size="small"
              color="primary"
              href="https://web-developer-react.vercel.app/about"
              target="_blank"
            >
              Share
            </Button>
          </CardActions>
        </Grid>
      </Grid>
    </>
  )
}
