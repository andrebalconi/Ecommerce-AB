import { Box, Typography } from '@mui/material'

interface Hero {
  Title: string
  subTitle: string
  destakTitle: string
  imageHero: any
  boxTitle: string
  boxSub: string
  boxText: string
}

export default function Hero({
  Title,
  destakTitle,
  subTitle,
  imageHero,
  boxTitle,
  boxSub,
  boxText,
}: Hero) {
  return (
    <Box>
      <Typography
        align="center"
        variant="h3"
        sx={{ width: { xs: '80%', sm: '90%', md: '100%' }, fontWeight: 900 }}
      >
        {Title} <b style={{ color: 'red' }}>{destakTitle}</b>
      </Typography>
      <Typography
        align="center"
        variant="body2"
        sx={{ width: { xs: '80%', sm: '90%', md: '100%' }, fontWeight: 100 }}
      >
        {subTitle}
      </Typography>
      <Box
        sx={{
          backgroundImage: `url(${imageHero})`,
          backgroundRepeat: 'no-repeat',
          backgroundColor: 'black',
          backgroundPosition: 'center',
          backgroundSize: 'cover',
          height: 600,
          width: '100%',
          display: 'flex',
          justifyContent: 'left',
        }}
      >
        <Box
          sx={{
            width: { xs: '60%', sm: '70%', md: '80%' },
            padding: { xs: 3, sm: 4, md: 15 },
          }}
        >
          <Box sx={{ background: 'white', opacity: '0.8' }}>
            <Typography variant="h6" color="tomato" align="center" pt={8}>
              {boxTitle}
            </Typography>
            <Typography variant="h4" align="center">
              {boxSub}
            </Typography>
            <Typography variant="body1" align="center" pb={8}>
              {boxText}
            </Typography>
          </Box>
        </Box>
      </Box>
    </Box>
  )
}
