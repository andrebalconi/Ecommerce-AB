import { ShoppingCart } from '@mui/icons-material'
import {
  AppBar,
  Badge,
  Box,
  Button,
  IconButton,
  List,
  ListItem,
  Menu,
  Switch,
  Toolbar,
  Typography,
} from '@mui/material'
import { useState } from 'react'
import { Link } from 'react-router-dom'
import { NavLink } from 'react-router-dom'
import { useAppSelector } from '../store/configureStore'
import SignedInMenu from './SignedInMenu'
import MenuIcon from '@mui/icons-material/Menu'

interface Props {
  darkMode: boolean
  handleThemeChange: () => void
}

const midLinks = [
  { title: 'catalog', path: '/catalog' },
  { title: 'about', path: '/about' },
  { title: 'contact', path: '/contact' },
]

const rightLinks = [
  { title: 'login', path: '/login' },
  { title: 'register', path: '/register' },
]

const navStyles = {
  color: 'inherit',
  textDecoration: 'none',
  typography: 'h6',
  '&:hover': {
    color: 'grey.500',
  },
  '&.active': {
    color: 'text.secondary',
  },
}

export default function Header({ darkMode, handleThemeChange }: Props) {
  const { basket } = useAppSelector((state) => state.basket)
  const { user } = useAppSelector((state) => state.account)
  const itemCount = basket?.items.reduce((sum, item) => sum + item.quantity, 0)

  const [anchorEl, setAnchorEl] = useState<null | HTMLElement>(null)
  const open = Boolean(anchorEl)
  const handleClick = (event: React.MouseEvent<HTMLButtonElement>) => {
    setAnchorEl(event.currentTarget)
  }
  const handleClose = () => {
    setAnchorEl(null)
  }

  return (
    <AppBar position="static" sx={{ mb: 4 }}>
      <Toolbar
        sx={{
          display: 'flex',
          justifyContent: 'space-between',
          alignItems: 'center',
        }}
      >
        <Box
          sx={{
            '@media (min-width:560px)': { display: 'flex' },
            '@media (max-width:390px)': { display: 'inLine' },
          }}
          alignItems="center"
        >
          <Typography variant="h6" component={NavLink} to="/" sx={navStyles}>
            E-commerce Peg
          </Typography>
          <Switch checked={darkMode} onChange={handleThemeChange} />
        </Box>

        <List
          sx={{
            '@media (min-width:560px)': { display: 'flex' },
            '@media (max-width:390px)': { display: 'none' },
          }}
        >
          {midLinks.map(({ title, path }) => (
            <ListItem component={NavLink} to={path} key={path} sx={navStyles}>
              {title.toUpperCase()}
            </ListItem>
          ))}
          {user && user.roles?.includes('Admin') &&
          <ListItem component={NavLink} to={'/inventory'} sx={navStyles}>
            INVENTORY
          </ListItem>}
        </List>
        <Box display="flex" alignItems="center">
          <IconButton
            component={Link}
            to="/basket"
            size="large"
            sx={{ color: 'inherit' }}
          >
            <Badge badgeContent={itemCount} color="secondary">
              <ShoppingCart />
            </Badge>
          </IconButton>
          {user ? (
            <SignedInMenu />
          ) : (
            <List
              sx={{
                '@media (min-width:560px)': { display: 'flex' },
                '@media (max-width:390px)': { display: 'none' },
              }}
            >
              {rightLinks.map(({ title, path }) => (
                <ListItem
                  component={NavLink}
                  to={path}
                  key={path}
                  sx={navStyles}
                >
                  {title.toUpperCase()}
                </ListItem>
              ))}
            </List>
          )}
        </Box>

        {/* Mobile Menu */}
        <Box
          sx={{
            '@media (min-width:560px)': { display: 'none' },
            '@media (max-width:390px)': { display: 'flex' },
          }}
        >
          <Button
            id="basic-button"
            aria-controls={open ? 'basic-menu' : undefined}
            aria-haspopup="true"
            aria-expanded={open ? 'true' : undefined}
            onClick={handleClick}
            sx={{ color: 'inherit' }}
          >
            <MenuIcon />
          </Button>
          <Menu
            id="basic-menu"
            anchorEl={anchorEl}
            open={open}
            onClose={handleClose}
            MenuListProps={{
              'aria-labelledby': 'basic-button',
            }}
          >
            <List>
              {midLinks.map(({ title, path }) => (
                <ListItem
                  component={NavLink}
                  to={path}
                  key={path}
                  sx={navStyles}
                >
                  {title.toUpperCase()}
                </ListItem>
              ))}
            </List>
          </Menu>
        </Box>
      </Toolbar>
    </AppBar>
  )
}
