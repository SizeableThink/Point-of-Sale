# README #

### Point of sale Functional Requirements Homework Assignment ###

The big picture: We’re developing an inventory and purchasing system for a regional franchise, our
client. The complete software system will include an inventory management system and will control the
point-of-sale checkout registers. Our team is responsible for the point-of-sale software, not the
inventory system. Because of the financial, tax, and legal liability of the client, the software accuracy
must be ensured and verified.

User Story: Compute the net price of all the items in a customer’s shopping cart including all applicable
discounts and taxes.

After discussing further with the client, we have defined the following functional requirements.
FR 1) If the shopping cart contains 10 or more items, the customers shall get a 10% discount off of the
purchase price before taxes are included. Otherwise, if the shopping cart contains more than 5
items, the customer shall receive a 5% discount before tax. The customer receives no discount if
less than 5 items. Otherwise, no discount is applied.
FR 2) If the customer is a member of the store’s discount shopping club, they shall receive an additional
10% discount off of the purchase price before taxes.
FR 3) Customers shall not purchase more than 50 items in a single checkout session.
FR 4) Unless a customer has tax-exempt status, the local sales tax rate of 4.5% shall be applied to the
net discounted price.
FR 5) Dollar amounts shall be rounded to the nearest cent ($0.01) before and after the tax rate is
applied.
FR 6) The net purchase before any discount, the net discount, the tax amount, and the net total due
shall all be reported in dollars.
