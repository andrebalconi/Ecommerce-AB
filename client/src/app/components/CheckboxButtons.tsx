import { CheckBox } from '@mui/icons-material'
import { FormGroup, FormControlLabel } from '@mui/material'
import { useState } from 'react'

interface Props {
  items: string[]
  children: string[] //checked
  onChange: (items: string[]) => void
}

export default function CheckboxButtons({ items, children, onChange }: Props) {
  const [checkedItems, setCheckedItems] = useState(children || [])

  function handleChecked(value: string) {
    const currentIndex = checkedItems.findIndex((item) => item === value)
    let newChecked: string[] = []
    if (currentIndex === -1) newChecked = [...checkedItems, value]
    else newChecked = checkedItems.filter((item) => item !== value)
    setCheckedItems(newChecked)
    onChange(newChecked)
  }

  return (
    <FormGroup>
      {items.map((item) => (
        <FormControlLabel
          control={
            <CheckBox
              children={checkedItems.indexOf(item) !== -1}
              onClick={() => handleChecked(item)}
            />
          }
          label={item}
          key={item}
        />
      ))}
    </FormGroup>
  )
}
